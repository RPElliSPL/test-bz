using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Base class that ElliciumHtmlEditor color picker tools inherit from.
    /// </summary>
    public abstract class ElliciumHtmlEditorColorBase : ElliciumHtmlEditorButtonBase
    {
        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.ShowHSV" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public bool ShowHSV { get; set; } = true;

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.ShowRGBA" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public bool ShowRGBA { get; set; } = true;

        /// <summary>
        /// Gets or sets the child content.
        /// </summary>
        /// <value>The child content.</value>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.ShowColors" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public bool ShowColors { get; set; } = true;

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.ShowButton" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public bool ShowButton { get; set; } = true;

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.HexText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string HexText { get; set; } = "Hex";

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.RedText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string RedText { get; set; } = "R";

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.GreenText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string GreenText { get; set; } = "G";

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.BlueText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string BlueText { get; set; } = "B";

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.AlphaText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string AlphaText { get; set; } = "A";

        /// <summary>
        /// Sets <see cref="ElliciumColorPicker.ButtonText" /> of the built-in ElliciumColorPicker.
        /// </summary>
        [Parameter]
        public string ButtonText { get; set; } = "OK";


        /// <summary>
        /// Handles the change event of built-in ElliciumColorPicker.
        /// </summary>
        /// <param name="value">The new color.</param>
        protected async Task OnChange(string value)
        {
            await Editor.ExecuteCommandAsync(CommandName, value);
        }
    }
}
