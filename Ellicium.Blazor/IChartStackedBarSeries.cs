using System.Collections.Generic;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Marker interface for <see cref="ElliciumStackedBarSeries{TItem}" />.
    /// </summary>
    public interface IChartStackedBarSeries : IChartBarSeries
    {
        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        double ValueAt(int index);

        /// <summary>
        /// Gets the values for category.
        /// </summary>
        IEnumerable<double> ValuesForCategory(double category);
    }
}