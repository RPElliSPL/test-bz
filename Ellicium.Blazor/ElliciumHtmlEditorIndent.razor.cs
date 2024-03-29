using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which indents the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorIndent /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorIndent : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "indent";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Indent"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Indent";
    }
}
