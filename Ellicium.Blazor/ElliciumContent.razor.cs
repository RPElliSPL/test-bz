using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumContent component.
    /// </summary>
    public partial class ElliciumContent : ElliciumComponentWithChildren
    {
        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>The container.</value>
        [Parameter]
        public string Container { get; set; }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "content";
        }
    }
}
