using Microsoft.AspNetCore.Components;
using System.Linq;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumLayout component.
    /// </summary>
    public partial class ElliciumLayout : ElliciumComponentWithChildren
    {
        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-layout";
        }
    }
}
