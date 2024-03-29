using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A tool which changes the font of the selected text.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorFontName /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorFontName
    {
        IList<ElliciumHtmlEditorFontNameItem> fonts = new List<ElliciumHtmlEditorFontNameItem>();

        internal void AddFont(ElliciumHtmlEditorFontNameItem font)
        {
            if (!fonts.Contains(font))
            {
                fonts.Add(font);
            }
        }

        /// <summary>
        /// Sets the child content.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Specifies the placeholder displayed to the user. Set to <c>"Font"</c> by default.
        /// </summary>
        [Parameter]
        public string Placeholder { get; set; } = "Font";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Font name"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Font name";

        /// <summary>
        /// The ElliciumHtmlEditor component which this tool is part of.
        /// </summary>
        [CascadingParameter]
        public ElliciumHtmlEditor Editor { get; set; }

        async Task OnChange(string value)
        {
            await Editor.ExecuteCommandAsync("fontName", value);
        }
    }
}
