﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Ellicium.Blazor.Rendering;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumSplitButtonItem component.
    /// </summary>
    public partial class ElliciumSplitButtonItem : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [Parameter]
        public string Text { get; set; } = "";

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        [Parameter]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the icon color.
        /// </summary>
        /// <value>The icon color.</value>
        [Parameter]
        public string IconColor { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [Parameter]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumSplitButtonItem"/> is disabled.
        /// </summary>
        /// <value><c>true</c> if disabled; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool Disabled { get; set; }

        ElliciumSplitButton _splitButton;
        /// <summary>
        /// Gets or sets the split button.
        /// </summary>
        /// <value>The split button.</value>
        [CascadingParameter]
        public ElliciumSplitButton SplitButton 
        {
            get
            {
                return _splitButton;
            }
            set
            {
                if (_splitButton != value)
                {
                    _splitButton = value;
                    _splitButton.AddItem(this);
                }
            }
        }


        /// <summary>
        /// Handles the <see cref="E:Click" /> event.
        /// </summary>
        /// <param name="args">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        public async System.Threading.Tasks.Task OnClick(MouseEventArgs args)
        {
            if (SplitButton != null && !Disabled)
            {
                SplitButton.Close();
                await SplitButton.Click.InvokeAsync(this);
            }
        }

        ClassList ItemClassList => ClassList.Create("rz-menuitem").AddDisabled(Disabled).Add("rz-state-focused", SplitButton.IsFocused(this));

        /// <inheritdoc />
        public override void Dispose()
        {
            base.Dispose();

            if (SplitButton != null)
            {
                SplitButton.RemoveItem(this);
            }
        }
    }
}
