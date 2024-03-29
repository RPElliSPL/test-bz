using Microsoft.AspNetCore.Components;
using Ellicium.Blazor.Rendering;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumFooter component.
    /// </summary>
    public partial class ElliciumFooter : ElliciumComponentWithChildren
    {
        /// <summary>
        /// The <see cref="ElliciumLayout" /> this component is nested in.
        /// </summary>
        [CascadingParameter]
        public ElliciumLayout Layout { get; set; }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return ClassList.Create("rz-footer")
                            .Add("fixed", Layout == null)
                            .ToString();
        }
    }
}
