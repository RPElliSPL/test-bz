using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which removes the styling of the selection.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorRemoveFormat /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorRemoveFormat : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "removeFormat";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Remove styling"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Remove styling";
    }
}
