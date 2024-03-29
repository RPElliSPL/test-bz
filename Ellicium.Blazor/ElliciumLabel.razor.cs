using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumLabel component.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumLabel Text="CompanyName" Component="CompanyName" /&gt;
    /// &lt;ElliciumTextBox Name="CompanyName" /&gt;
    /// </code>
    /// </example>
    public partial class ElliciumLabel : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the child content.
        /// </summary>
        /// <value>The child content.</value>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Gets or sets the component name for the label.
        /// </summary>
        /// <value>The component name for the label.</value>
        [Parameter]
        public string Component { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [Parameter]
        public string Text { get; set; } = "";

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-label";
        }
    }
}
