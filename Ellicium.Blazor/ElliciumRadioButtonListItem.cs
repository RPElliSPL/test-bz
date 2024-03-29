using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumRadioButtonListItem component.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public class ElliciumRadioButtonListItem<TValue> : ElliciumComponent
    {
        /// <summary>
        /// Specifies additional custom attributes that will be rendered by the input.
        /// </summary>
        /// <value>The attributes.</value>
        [Parameter]
        public IReadOnlyDictionary<string, object> InputAttributes { get; set; }

        private string _text;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [Parameter]
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value != _text)
                {
                    _text = value;

                    if (List != null)
                        List.Refresh();
                }
            }
        }

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>The template.</value>
        [Parameter]
        public RenderFragment<ElliciumRadioButtonListItem<TValue>> Template { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [Parameter]
        public TValue Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumRadioButtonListItem{TValue}"/> is disabled.
        /// </summary>
        /// <value><c>true</c> if disabled; otherwise, <c>false</c>.</value>
        [Parameter]
        public virtual bool Disabled { get; set; }

        ElliciumRadioButtonList<TValue> _list;

        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>The list.</value>
        [CascadingParameter]
        public ElliciumRadioButtonList<TValue> List
        {
            get
            {
                return _list;
            }
            set
            {
                if (_list != value)
                {
                    _list = value;
                    _list.AddItem(this);
                }
            }
        }

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            List?.RemoveItem(this);
        }

        internal void SetText(string value)
        {
            Text = value;
        }

        internal void SetValue(TValue value)
        {
            Value = value;
        }

        internal void SetDisabled(bool value)
        {
            Disabled = value;
        }

        internal void SetVisible(bool value)
        {
            Visible = value;
        }

        internal string GetItemId()
        {
            return GetId();
        }

        internal string GetItemCssClass()
        {
            return GetCssClass();
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-radio-btn";
        }
    }
}