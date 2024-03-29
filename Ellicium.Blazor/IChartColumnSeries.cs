namespace Ellicium.Blazor
{
    /// <summary>
    /// Marker interface for <see cref="ElliciumColumnSeries{TItem}" />.
    /// </summary>
    public interface IChartColumnSeries
    {
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        int Count { get; }
    }
}