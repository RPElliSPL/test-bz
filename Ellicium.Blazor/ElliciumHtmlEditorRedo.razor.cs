using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A ElliciumHtmlEditor tool which repeats the last undone command.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumHtmlEditor @bind-Value=@html&gt;
    ///  &lt;ElliciumHtmlEditorRedo /&gt;
    /// &lt;/ElliciumHtmlEdito&gt;
    /// @code {
    ///   string html = "@lt;strong&gt;Hello&lt;/strong&gt; world!"; 
    /// }
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorRedo : ElliciumHtmlEditorButtonBase
    {
        /// <inheritdoc />
        protected override string CommandName => "redo";

        /// <summary>
        /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to <c>"Redo"</c> by default.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Redo";
    }
}
