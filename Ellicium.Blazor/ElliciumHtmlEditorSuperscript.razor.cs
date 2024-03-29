using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which formats the selection as superscript.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorSuperscript /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorSuperscript : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "superscript";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Superscript"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Superscript";
    }
}
