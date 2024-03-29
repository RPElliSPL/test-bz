using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which bolds the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorBold /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!";
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorBold : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "bold";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Bold"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Bold";

        /// <summary>
        /// Specifies the shortcut for the command. Set to <c>"Ctrl+B"</c> by default.
        /// </summary>
        [Parameter]
        public override string Shortcut { get; set; } = "Ctrl+B";
    }
}
