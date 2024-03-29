using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumMenu component.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumMenu&gt;
    ///     &lt;ElliciumMenuItem Text="Data"&gt;
    ///         &lt;ElliciumMenuItem Text="Orders" Path="orders" /&gt;
    ///         &lt;ElliciumMenuItem Text="Employees" Path="employees" /&gt;
    ///     &lt;/ElliciumMenuItemItem&gt;
    /// &lt;/ElliciumMenu&gt;
    /// </code>
    /// </example>
    public partial class ElliciumMenu : ElliciumComponentWithChildren
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumMenu"/> is responsive.
        /// </summary>
        /// <value><c>true</c> if responsive; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool Responsive { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumMenu"/> should open item on click or on hover.
        /// </summary>
        /// <value><c>true</c> if open item on click; otherwise, <c>false</c> and items will open on hover.</value>
        [Parameter]
        public bool ClickToOpen { get; set; } = true;

        private bool IsOpen { get; set; } = false;

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            var classList = new List<string>();

            classList.Add("rz-menu");

            if (Responsive)
            {
                if (IsOpen)
                {
                    classList.Add("rz-menu-open");
                }
                else
                {
                    classList.Add("rz-menu-closed");
                }
            }

            return string.Join(" ", classList);
        }

        void OnToggle()
        {
            IsOpen = !IsOpen;
        }

        /// <summary>
        /// Gets or sets the click callback.
        /// </summary>
        /// <value>The click callback.</value>
        [Parameter]
        public EventCallback<MenuItemEventArgs> Click { get; set; }


        [Inject]
        NavigationManager NavigationManager { get; set; }

        bool subMenuOpen = false;
        internal int focusedIndex = -1;
        bool preventKeyPress = true;
        async Task OnKeyPress(KeyboardEventArgs args)
        {
            var key = args.Code != null ? args.Code : args.Key;

            if (currentItems == null)
            {
                currentItems = items.Where(i => i.Visible && !i.Disabled).ToList();
            }

            if (key == "ArrowUp" || key == "ArrowDown")
            {
                preventKeyPress = true;

                if (subMenuOpen)
                {
                    focusedIndex = Math.Clamp(focusedIndex + (key == "ArrowUp" ? -1 : 1), 0, currentItems.Count - 1);
                }
                else
                {
                    if (key == "ArrowDown")
                    {
                        var item = currentItems[focusedIndex];

                        if (item.items.Any())
                        {
                            currentItems = item.items.Where(i => i.Visible && !i.Disabled).ToList();
                            focusedIndex = -1;
                            subMenuOpen = true;
                            await item.Open();
                        }
                    }
                }
            }
            else if (key == "ArrowLeft" || key == "ArrowRight")
            {
                preventKeyPress = true;

                bool shouldOpenNextMenu = false;
                if (subMenuOpen)
                {
                    var parentItem = currentItems.FirstOrDefault().ParentItem;
                    if (parentItem != null)
                    {
                        currentItems = parentItem.Parent.items.Where(i => i.Visible && !i.Disabled).ToList();
                        focusedIndex = currentItems.IndexOf(parentItem);
                        subMenuOpen = false;
                        await parentItem.Close();
                        shouldOpenNextMenu = true;
                    }
                }

                focusedIndex = Math.Clamp(focusedIndex + (key == "ArrowLeft" ? -1 : 1), 0, currentItems.Count - 1);

                if (shouldOpenNextMenu)
                {
                    shouldOpenNextMenu = false;

                    var item = currentItems[focusedIndex];

                    if (item.items.Any())
                    {
                        currentItems = item.items.Where(i => i.Visible && !i.Disabled).ToList();
                        focusedIndex = -1;
                        subMenuOpen = true;
                        await item.Toggle();
                    }
                }
            }
            else if (key == "Space" || key == "Enter")
            {
                preventKeyPress = true;

                if (focusedIndex >= 0 && focusedIndex < currentItems.Count)
                {
                    var item = currentItems[focusedIndex];

                    if (item.items.Any())
                    {
                        currentItems = item.items.Where(i => i.Visible && !i.Disabled).ToList();
                        focusedIndex = -1;
                        subMenuOpen = true;
                        await item.Toggle();
                    }
                    else
                    {
                        if (item.Path != null)
                        {
                            NavigationManager.NavigateTo(item.Path);
                        }
                        else
                        {
                            await item.OnClick(new MouseEventArgs());
                        }
                    }
                }
            }
            else if (key == "Escape")
            {
                preventKeyPress = true;

                if (currentItems.Any(i => i.ParentItem != null))
                {
                    var parentItem = currentItems.FirstOrDefault().ParentItem;
                    if (parentItem != null)
                    {
                        currentItems = (parentItem.ParentItem != null ? parentItem.ParentItem.items : parentItem.Parent.items).Where(i => i.Visible && !i.Disabled).ToList();
                        focusedIndex = currentItems.IndexOf(parentItem);
                        subMenuOpen = false;
                        await parentItem.Close();
                    }
                }
            }
            else
            {
                preventKeyPress = false;
            }
        }

        internal bool IsFocused(ElliciumMenuItem item)
        {
            return currentItems?.IndexOf(item) == focusedIndex && focusedIndex != -1;
        }

        List<ElliciumMenuItem> currentItems;

        internal List<ElliciumMenuItem> items = new List<ElliciumMenuItem>();

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem(ElliciumMenuItem item)
        {
            if (items.IndexOf(item) == -1)
            {
                items.Add(item);
                StateHasChanged();
            }
        }
    }
}
