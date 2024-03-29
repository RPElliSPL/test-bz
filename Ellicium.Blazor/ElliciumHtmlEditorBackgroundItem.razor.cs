using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Adds a custom color to <see cref="ElliciumHtmlEditorBackground" />.
    /// </summary>
    /// <example>
    /// <code>
    ///  &lt;ElliciumHtmlEditorBackground &gt;
    ///     &lt;ElliciumHtmlEditorBackgroundItem Value="red" /&gt;
    ///     &lt;ElliciumHtmlEditorBackgroundItem Value="green" /&gt;
    ///  &lt;/ElliciumHtmlEditorBackground &gt;
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorBackgroundItem
    {
        /// <summary>
        /// The custom color to add.
        /// </summary>
        [Parameter]
        public string Value { get; set; }
    }
}
