using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which underlines the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorUnderline /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!";
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorUnderline : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "underline";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Underline"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Underline";

        /// <summary>
        /// Specifies the shortcut for the command. Set to <c>"Ctrl+U"</c> by default.
        /// </summary>
        [Parameter]
        public override string Shortcut { get; set; } = "Ctrl+U";
    }
}
