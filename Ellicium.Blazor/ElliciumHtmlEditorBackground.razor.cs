using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which sets the background color of the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorBackground /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorBackground : ElliciumHtmlEditorColorBase
    {
        /// <inheritdoc />
        protected override string CommandName => "backColor";

        /// <summary>
        /// Specifies the default background color. Set to <c>"rgb(0, 0, 255)"</c> by default;
        /// </summary>
        [Parameter]
        public string Value { get; set; } = "rgb(0, 0, 255)";
        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Background color"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Background color";
    }
}
