using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumContentContainer component.
    /// </summary>
    public partial class ElliciumContentContainer : ElliciumComponentWithChildren
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Parameter]
        public string Name { get; set; }
    }
}
