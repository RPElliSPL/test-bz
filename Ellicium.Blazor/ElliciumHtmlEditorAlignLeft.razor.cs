using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which aligns the selection to the left.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorAlignLeft /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorAlignLeft : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "justifyLeft";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Align left"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Align left";
    }
}
