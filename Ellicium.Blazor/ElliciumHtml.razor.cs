using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumHtml component.
    /// </summary>
    public partial class ElliciumHtml : ComponentBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ElliciumHtml"/> is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool Visible { get; set; } = true;

        /// <summary>
        /// Gets or sets the child content.
        /// </summary>
        /// <value>The child content.</value>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
