using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which makes the selection italic.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorItalic /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!";
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorItalic : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "italic";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Italic"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Italic";

        /// <summary>
        /// Specifies the shortcut for the command. Set to <c>"Ctrl+I"</c> by default.
        /// </summary>
        [Parameter]
        public override string Shortcut { get; set; } = "Ctrl+I";
    }
}
