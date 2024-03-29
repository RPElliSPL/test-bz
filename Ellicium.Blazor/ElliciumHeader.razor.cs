using Microsoft.AspNetCore.Components;
using Ellicium.Blazor.Rendering;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumHeader component.
    /// </summary>
    public partial class ElliciumHeader : ElliciumComponentWithChildren
    {
        /// <summary>
        /// The <see cref="ElliciumLayout" /> this component is nested in.
        /// </summary>
        [CascadingParameter]
        public ElliciumLayout Layout { get; set; }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return ClassList.Create("rz-header")
                            .Add("fixed", Layout == null)
                            .ToString();
        }
    }
}
