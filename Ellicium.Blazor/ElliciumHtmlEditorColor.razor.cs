using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which sets the text color of the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorColor /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorColor : ElliciumHtmlEditorColorBase
    {
        /// <inheritdoc />
        protected override string CommandName => "foreColor";

        /// <summary>
        /// Specifies the default text color. Set to <c>"rgb(255, 0, 0)"</c> by default;
        /// </summary>
        [Parameter]
        public string Value { get; set; } = "rgb(255, 0, 0)";
        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Text color"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Text color";
    }
}
