using System.Collections.Generic;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Marker interface for <see cref="ElliciumStackedColumnSeries{TItem}" />.
    /// </summary>
    public interface IChartStackedColumnSeries
    {
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        int Count { get; }

        /// <summary>
        /// Gets the values for category.
        /// </summary>
        IEnumerable<double> ValuesForCategory(double category);

        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        double ValueAt(int index);
    }
}