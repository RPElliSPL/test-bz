using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Renders donut series in <see cref="ElliciumChart" />.
    /// </summary>
    /// <typeparam name="TItem">The type of the series data item.</typeparam>
    public partial class ElliciumDonutSeries<TItem> : ElliciumPieSeries<TItem>, IChartDonutSeries
    {
        /// <summary>
        /// Gets or sets the inner radius of the donut.
        /// </summary>
        /// <value>The inner radius.</value>
        [Parameter]
        public double? InnerRadius { get; set; }

        /// <summary>
        /// Gets or sets the title template.
        /// </summary>
        /// <value>The title template.</value>
        [Parameter]
        public RenderFragment TitleTemplate { get; set; }
    }
}
