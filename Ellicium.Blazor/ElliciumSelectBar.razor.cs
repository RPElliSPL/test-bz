using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Ellicium.Blazor.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumSelectBar component.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <example>
    /// <code>
    /// &lt;ElliciumSelectBar @bind-Value=@values TValue="IEnumerable&lt;int&gt;" Multiple="true"&gt;
    ///     &lt;Items&gt;
    ///         &lt;ElliciumSelectBarItem Text="Orders" Value="1" /&gt;
    ///         &lt;ElliciumSelectBarItem Text="Employees" Value="2" /&gt;
    ///         &lt;ElliciumSelectBarItem Text="Customers" Value="3" /&gt;
    ///     &lt;/Items&gt;
    /// &lt;/ElliciumSelectBar&gt;
    /// </code>
    /// </example>
    public partial class ElliciumSelectBar<TValue> : FormComponent<TValue>, IElliciumSelectBar
    {
        private string getButtonSize()
        {
            return Size == ButtonSize.Medium ? "md" : Size == ButtonSize.Large ? "lg" : Size == ButtonSize.Small ? "sm" : "xs";
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [Parameter]
        public ButtonSize Size { get; set; } = ButtonSize.Medium;


        ClassList ButtonClassList(ElliciumSelectBarItem item) => ClassList.Create($"rz-button rz-button-{getButtonSize()} rz-button-text-only")
                            .Add("rz-state-active", IsSelected(item))
                            .AddDisabled(Disabled || item.Disabled);

        /// <summary>
        /// Gets or sets the value property.
        /// </summary>
        /// <value>The value property.</value>
        [Parameter]
        public string ValueProperty { get; set; }

        /// <summary>
        /// Gets or sets the text property.
        /// </summary>
        /// <value>The text property.</value>
        [Parameter]
        public string TextProperty { get; set; }

        IEnumerable<ElliciumSelectBarItem> allItems
        {
            get
            {
                return items.Concat((Data != null ? Data.Cast<object>() : Enumerable.Empty<object>()).Select(i =>
                {
                    var item = new ElliciumSelectBarItem();
                    item.SetText((string)PropertyAccess.GetItemOrValueFromProperty(i, TextProperty));
                    item.SetValue(PropertyAccess.GetItemOrValueFromProperty(i, ValueProperty));
                    return item;
                }));
            }
        }

        IEnumerable _data = null;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        [Parameter]
        public virtual IEnumerable Data
        {
            get
            {
                return _data;
            }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    StateHasChanged();
                }
            }
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return GetClassList("rz-selectbutton rz-buttonset").Add($"rz-buttonset-{items.Count}").ToString();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumSelectBar{TValue}"/> is multiple.
        /// </summary>
        /// <value><c>true</c> if multiple; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool Multiple { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [Parameter]
        public RenderFragment Items { get; set; }

        List<ElliciumSelectBarItem> items = new List<ElliciumSelectBarItem>();

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem(ElliciumSelectBarItem item)
        {
            if (items.IndexOf(item) == -1)
            {
                items.Add(item);
                StateHasChanged();
            }
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void RemoveItem(ElliciumSelectBarItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                if (!disposed)
                {
                    try { InvokeAsync(StateHasChanged); } catch { }
                }
            }
        }

        /// <summary>
        /// Determines whether the specified item is selected.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if the specified item is selected; otherwise, <c>false</c>.</returns>
        protected bool IsSelected(ElliciumSelectBarItem item)
        {
            if (Multiple)
            {
                return Value != null && ((IEnumerable)Value).Cast<object>().Contains(item.Value);
            }
            else
            {
                return object.Equals(Value, item.Value);
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has value.
        /// </summary>
        /// <value><c>true</c> if this instance has value; otherwise, <c>false</c>.</value>
        public override bool HasValue
        {
            get
            {
                return Multiple ? Value != null && ((IEnumerable)Value).Cast<object>().Any() : Value != null;
            }
        }

        /// <summary>
        /// Selects the item.
        /// </summary>
        /// <param name="item">The item.</param>
        protected async System.Threading.Tasks.Task SelectItem(ElliciumSelectBarItem item)
        {
            if (Disabled || item.Disabled)
                return;

            if (Multiple)
            {
                var type = typeof(TValue).IsGenericType ? typeof(TValue).GetGenericArguments()[0] : typeof(TValue);

                var selectedValues = Value != null ? QueryableExtension.ToList(((IEnumerable)Value).AsQueryable().Cast(type)) : new List<dynamic>();

                if (!selectedValues.Contains(item.Value))
                {
                    selectedValues.Add(item.Value);
                }
                else
                {
                    selectedValues.Remove(item.Value);
                }

                Value = (TValue)selectedValues.AsQueryable().Cast(type);
            }
            else
            {
                Value = (TValue)item.Value;
            }

            await ValueChanged.InvokeAsync(Value);
            if (FieldIdentifier.FieldName != null) { EditContext?.NotifyFieldChanged(FieldIdentifier); }
            await Change.InvokeAsync(Value);

            StateHasChanged();
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        public void Refresh()
        {
            StateHasChanged();
        }

        bool preventKeyPress = true;
        async Task OnKeyPress(KeyboardEventArgs args, Task task)
        {
            var key = args.Code != null ? args.Code : args.Key;

            if (key == "Space" || key == "Enter")
            {
                preventKeyPress = true;

                await task;
            }
            else
            {
                preventKeyPress = false;
            }
        }
    }
}