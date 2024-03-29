using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A component which displays a hierarchy of items. Supports inline definition and data-binding.
    /// </summary>
    /// <example>
    ///   <code>
    /// &lt;ElliciumTree&gt;
    ///     &lt;ElliciumTreeItem Text="BMW"&gt;
    ///         &lt;ElliciumTreeItem Text="M3" /&gt;
    ///         &lt;ElliciumTreeItem Text="M5" /&gt;
    ///     &lt;/ElliciumTreeItem&gt;
    ///     &lt;ElliciumTreeItem Text="Audi"&gt;
    ///         &lt;ElliciumTreeItem Text="RS4" /&gt;
    ///         &lt;ElliciumTreeItem Text="RS6" /&gt;
    ///     &lt;/ElliciumTreeItem&gt;
    ///     &lt;ElliciumTreeItem Text="Mercedes"&gt;
    ///         &lt;ElliciumTreeItem Text="C63 AMG" /&gt;
    ///         &lt;ElliciumTreeItem Text="S63 AMG" /&gt;
    ///     &lt;/ElliciumTreeItem&gt;
    /// &lt;/ElliciumTree&gt;
    ///   </code>
    /// </example>
    public partial class ElliciumTree : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the open button aria-label attribute.
        /// </summary>
        [Parameter]
        public string SelectItemAriaLabel { get; set; } = "Select item";

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-tree";
        }

        internal ElliciumTreeItem SelectedItem { get; private set; }

        IList<ElliciumTreeLevel> Levels { get; set; } = new List<ElliciumTreeLevel>();

        /// <summary>
        /// A callback that will be invoked when the user selects an item.
        /// </summary>
        /// <example>
        /// <code>
        /// &lt;ElliciumTree Change=@OnChange&gt;
        ///     &lt;ElliciumTreeItem Text="BMW"&gt;
        ///         &lt;ElliciumTreeItem Text="M3" /&gt;
        ///         &lt;ElliciumTreeItem Text="M5" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        ///     &lt;ElliciumTreeItem Text="Audi"&gt;
        ///         &lt;ElliciumTreeItem Text="RS4" /&gt;
        ///         &lt;ElliciumTreeItem Text="RS6" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        ///     &lt;ElliciumTreeItem Text="Mercedes"&gt;
        ///         &lt;ElliciumTreeItem Text="C63 AMG" /&gt;
        ///         &lt;ElliciumTreeItem Text="S63 AMG" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        /// &lt;/ElliciumTree&gt;
        /// @code {
        ///   void OnChange(TreeEventArgs args) 
        ///   {
        /// 
        ///   }
        /// }
        /// </code>
        /// </example>
        [Parameter]
        public EventCallback<TreeEventArgs> Change { get; set; }

        /// <summary>
        /// A callback that will be invoked when the user expands an item.
        /// </summary>
        /// <example>
        /// <code>
        /// &lt;ElliciumTree Expand=@OnExpand&gt;
        ///     &lt;ElliciumTreeItem Text="BMW"&gt;
        ///         &lt;ElliciumTreeItem Text="M3" /&gt;
        ///         &lt;ElliciumTreeItem Text="M5" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        ///     &lt;ElliciumTreeItem Text="Audi"&gt;
        ///         &lt;ElliciumTreeItem Text="RS4" /&gt;
        ///         &lt;ElliciumTreeItem Text="RS6" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        ///     &lt;ElliciumTreeItem Text="Mercedes"&gt;
        ///         &lt;ElliciumTreeItem Text="C63 AMG" /&gt;
        ///         &lt;ElliciumTreeItem Text="S63 AMG" /&gt;
        ///     &lt;/ElliciumTreeItem&gt;
        /// &lt;/ElliciumTree&gt;
        /// @code {
        ///   void OnExpand(TreeExpandEventArgs args) 
        ///   {
        /// 
        ///   }
        /// }
        /// </code>
        /// </example>
        [Parameter]
        public EventCallback<TreeExpandEventArgs> Expand { get; set; }

        /// <summary>
        /// A callback that will be invoked when the user collapse an item.
        /// </summary>
        [Parameter]
        public EventCallback<TreeEventArgs> Collapse { get; set; }

        /// <summary>
        /// Gets or sets the child content.
        /// </summary>
        /// <value>The child content.</value>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Specifies the collection of data items which ElliciumTree will create its items from.
        /// </summary>
        [Parameter]
        public IEnumerable Data { get; set; }

        /// <summary>
        /// Specifies the selected value. Use with <c>@bind-Value</c> to sync it with a property.
        /// </summary>
        [Parameter]
        public object Value { get; set; }

        /// <summary>
        /// A callback which will be invoked when <see cref="Value" /> changes.
        /// </summary>
        [Parameter]
        public EventCallback<object> ValueChanged { get; set; }

        /// <summary>
        /// Specifies whether ElliciumTree displays check boxes. Set to <c>false</c> by default.
        /// </summary>
        /// <value><c>true</c> if check boxes are displayed; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool AllowCheckBoxes { get; set; }

        /// <summary>
        /// Specifies what happens when a parent item is checked. If set to <c>true</c> checking parent items also checks all of its children.
        /// </summary>
        [Parameter]
        public bool AllowCheckChildren { get; set; } = true;

        /// <summary>
        /// Specifies what happens with a parent item when one of its children is checked. If set to <c>true</c> checking a child item will affect the checked state of its parents.
        /// </summary>
        [Parameter]
        public bool AllowCheckParents { get; set; } = true;

        /// <summary>
        /// Specifies whether siblings items are collapsed. Set to <c>false</c> by default.
        /// </summary>
        [Parameter]
        public bool SingleExpand { get; set; }

        /// <summary>
        /// Gets or sets the checked values. Use with <c>@bind-CheckedValues</c> to sync it with a property.
        /// </summary>
        [Parameter]
        public IEnumerable<object> CheckedValues { get; set; } = Enumerable.Empty<object>();

        internal List<ElliciumTreeItem> items = new List<ElliciumTreeItem>();

        internal void AddItem(ElliciumTreeItem item)
        {
            if (items.IndexOf(item) == -1)
            {
                items.Add(item);
            }
        }

        internal void RemoveItem(ElliciumTreeItem item)
        {
            if (items.IndexOf(item) != -1)
            {
                items.Remove(item);
            }
        }

        internal async Task SetCheckedValues(IEnumerable<object> values)
        {
            CheckedValues = values != null ? values.ToList() : null;
            await CheckedValuesChanged.InvokeAsync(CheckedValues);
        }

        internal IEnumerable<object> UncheckedValues { get; set; } = Enumerable.Empty<object>();

        internal void SetUncheckedValues(IEnumerable<object> values)
        {
            UncheckedValues = values.ToList();
        }

        /// <summary>
        /// A callback which will be invoked when <see cref="CheckedValues" /> changes.
        /// </summary>
        [Parameter]
        public EventCallback<IEnumerable<object>> CheckedValuesChanged { get; set; }

        void RenderTreeItem(RenderTreeBuilder builder, object data, RenderFragment<ElliciumTreeItem> template, Func<object, string> text,
            Func<object, bool> hasChildren, Func<object, bool> expanded, Func<object, bool> selected, IEnumerable children = null)
        {
            builder.OpenComponent<ElliciumTreeItem>(0);
            builder.AddAttribute(1, nameof(ElliciumTreeItem.Text), text(data));
            builder.AddAttribute(2, nameof(ElliciumTreeItem.Value), data);
            builder.AddAttribute(3, nameof(ElliciumTreeItem.HasChildren), hasChildren(data));
            builder.AddAttribute(4, nameof(ElliciumTreeItem.Template), template);
            builder.AddAttribute(5, nameof(ElliciumTreeItem.Expanded), expanded(data));
            builder.AddAttribute(6, nameof(ElliciumTreeItem.Selected), Value == data || selected(data));
            builder.SetKey(data);
        }

        RenderFragment RenderChildren(IEnumerable children, int depth)
        {
            var level = depth < Levels.Count() ? Levels.ElementAt(depth) : Levels.Last();

            return new RenderFragment(builder =>
            {
                Func<object, string> text = null;

                foreach (var data in children)
                {
                    if (text == null)
                    {
                        text = level.Text ?? Getter<string>(data, level.TextProperty);
                    }

                    RenderTreeItem(builder, data, level.Template, text, level.HasChildren, level.Expanded, level.Selected);

                    var hasChildren = level.HasChildren(data);

                    if (!string.IsNullOrEmpty(level.ChildrenProperty))
                    {
                        var grandChildren = PropertyAccess.GetValue(data, level.ChildrenProperty) as IEnumerable;

                        if (grandChildren != null && hasChildren)
                        {
                            builder.AddAttribute(7, "ChildContent", RenderChildren(grandChildren, depth + 1));
                            builder.AddAttribute(8, nameof(ElliciumTreeItem.Data), grandChildren);
                        }
                        else
                        {
                            builder.AddAttribute(7, "ChildContent", (RenderFragment)null);
                        }
                    }

                    builder.CloseComponent();
                }
            });
        }

        internal async Task SelectItem(ElliciumTreeItem item)
        {
            var selectedItem = SelectedItem;

            if (selectedItem != item)
            {
                SelectedItem = item;

                selectedItem?.Unselect();

                if (Value != item.Value)
                {
                    await ValueChanged.InvokeAsync(item.Value);
                }

                await Change.InvokeAsync(new TreeEventArgs()
                {
                    Text = item?.Text,
                    Value = item?.Value
                });
            }
        }
        /// <summary>
        /// Clear the current selection to allow re-selection by mouse click
        /// </summary>
        public void ClearSelection()
        {
            SelectedItem?.Unselect();
            SelectedItem = null;
        }
        internal async Task ExpandItem(ElliciumTreeItem item)
        {
            var args = new TreeExpandEventArgs()
            {
                Text = item?.Text,
                Value = item?.Value,
                Children = new TreeItemSettings()
            };

            await Expand.InvokeAsync(args);

            if (args.Children.Data != null)
            {
                var childContent = new RenderFragment(builder =>
                {
                    Func<object, string> text = null;
                    var children = args.Children;

                    foreach (var data in children.Data)
                    {
                        if (text == null)
                        {
                            text = children.Text ?? Getter<string>(data, children.TextProperty);
                        }

                        RenderTreeItem(builder, data, children.Template, text, children.HasChildren, children.Expanded, children.Selected);
                        builder.CloseComponent();
                    }
                });

                item.RenderChildContent(childContent);

                if (AllowCheckBoxes && AllowCheckChildren && args.Children.Data != null)
                {
                    if (CheckedValues != null)
                    {
                        if (CheckedValues.Contains(item.Value))
                        {
                            await SetCheckedValues(CheckedValues.Union(args.Children.Data.Cast<object>().Except(UncheckedValues)));
                        }
                        else
                        {
                            await SetCheckedValues(CheckedValues.Except(args.Children.Data.Cast<object>()));
                        }
                    }
                }
            }
            else if (item.Data != null)
            {
                if (AllowCheckBoxes && AllowCheckChildren && item.Data != null)
                {
                    if (CheckedValues != null && CheckedValues.Contains(item.Value))
                    {
                        await SetCheckedValues(CheckedValues.Union(item.Data.Cast<object>().Except(UncheckedValues)));
                    }
                    else
                    {
                        await SetCheckedValues(CheckedValues);
                    }
                }
            }
        }

        Func<object, T> Getter<T>(object data, string property)
        {
            if (string.IsNullOrEmpty(property))
            {
                return (value) => (T)value;
            }

            return PropertyAccess.Getter<T>(data, property);
        }

        /// <inheritdoc />
        public override async Task SetParametersAsync(ParameterView parameters)
        {
            if (parameters.DidParameterChange(nameof(Value), Value))
            {
                var value = parameters.GetValueOrDefault<object>(nameof(Value));

                if (value == null)
                {
                    SelectedItem = null;
                }
            }

            await base.SetParametersAsync(parameters);
        }

        internal void AddLevel(ElliciumTreeLevel level)
        {
            if (!Levels.Contains(level))
            {
                Levels.Add(level);
                StateHasChanged();
            }
        }

        internal int focusedIndex = -1;

        bool preventKeyPress = true;
        async Task OnKeyPress(KeyboardEventArgs args)
        {
            var key = args.Code != null ? args.Code : args.Key;

            if (key == "ArrowUp" || key == "ArrowDown")
            {
                preventKeyPress = true;

                focusedIndex = Math.Clamp(focusedIndex + (key == "ArrowUp" ? -1 : 1), 0, CurrentItems.Count - 1);
            }
            else if (key == "ArrowLeft" || key == "ArrowRight")
            {
                preventKeyPress = true;

                if (focusedIndex >= 0 && focusedIndex < CurrentItems.Count)
                {
                    var item = CurrentItems[focusedIndex];

                    if (item.ChildContent != null || item.HasChildren)
                    {
                        await item.ExpandCollapse(key == "ArrowRight");
                    }
                }
            }
            else if (key == "Enter" || key == "Space")
            {
                preventKeyPress = true;

                if (focusedIndex >= 0 && focusedIndex < CurrentItems.Count)
                {
                    await SelectItem(CurrentItems[focusedIndex]);

                    if (AllowCheckBoxes)
                    {
                        await CurrentItems[focusedIndex].CheckedChange(!CurrentItems[focusedIndex].IsChecked());
                    }
                }
            }
            else
            {
                preventKeyPress = false;
            }
        }

        internal bool IsFocused(ElliciumTreeItem item)
        {
            return CurrentItems.IndexOf(item) == focusedIndex && focusedIndex != -1;
        }

        internal void InsertInCurrentItems(int index, ElliciumTreeItem item)
        {
            if (index <= CurrentItems.Count)
            {
                CurrentItems.Insert(index, item);
            }
        }

        internal void RemoveFromCurrentItems(int index, int count)
        {
            if (index >= 0)
            {
                CurrentItems.RemoveRange(index, count);
            }

            if (focusedIndex > index)
            {
                focusedIndex = index;
            }
        }

        List<ElliciumTreeItem> _currentItems;
        internal List<ElliciumTreeItem> CurrentItems
        {
            get
            {
                if (_currentItems == null)
                {
                    _currentItems = items;
                }

                return _currentItems;
            }
        }
    }
}
