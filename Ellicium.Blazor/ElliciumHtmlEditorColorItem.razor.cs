using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Adds a custom color to <see cref="ElliciumHtmlEditorColor" />.
    /// </summary>
    /// <example>
    /// <code>
    ///  &lt;ElliciumHtmlEditorColor &gt;
    ///     &lt;ElliciumHtmlEditorColorItem Value="red" /&gt;
    ///     &lt;ElliciumHtmlEditorColorItem Value="green" /&gt;
    ///  &lt;/ElliciumHtmlEditorColor &gt;
    /// </code>
    /// </example>
    public partial class ElliciumHtmlEditorColorItem
    {
        /// <summary>
        /// The custom color to add.
        /// </summary>
        [Parameter]
        public string Value { get; set; }
    }
}
