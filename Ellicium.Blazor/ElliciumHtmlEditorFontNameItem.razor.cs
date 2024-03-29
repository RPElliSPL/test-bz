using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Adds a custom font to a <see cref="ElliciumHtmlEditorFontName" />.
    /// </summary>
    /// <example>
    /// <code>
    ///  &lt;ElliciumHtmlEditorFontName&gt;
    ///  &lt;ElliciumHtmlEditorFontNameItem Text="Times New Roman" Value='"Times New Roman"' /&gt;
    ///  &lt;/ElliciumHtmlEditorFontName&gt;
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorFontNameItem
    {
        /// <summary>
        /// The name of the font e.g. <c>"Times New Roman"</c>.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// The CSS value of the font. Use quotes if it contains spaces.
        /// </summary>
        [Parameter]
        public string Value { get; set; }

        /// <summary>
        /// The ElliciumHtmlEditorFontName tool which this tool belongs to.
        /// </summary>
        [CascadingParameter]
        public ElliciumHtmlEditorFontName Parent { get; set; }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            Parent.AddFont(this);
        }
    }
}
