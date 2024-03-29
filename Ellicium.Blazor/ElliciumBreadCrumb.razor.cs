using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A component to display a Bread Crumb style menu
    /// </summary>
    public partial class ElliciumBreadCrumb : ElliciumComponentWithChildren
    {
        /// <summary>
        /// An optional RenderFragment that is rendered per Item
        /// </summary>
        [Parameter]
        public RenderFragment<ElliciumBreadCrumbItem> Template { get; set; }

        /// <inheritdoc/>
        protected override string GetComponentCssClass()
        {
            return "rz-breadcrumb";
        }
    }

}
