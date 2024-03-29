namespace Ellicium.Blazor
{
    /// <summary>
    /// Common axis API of <see cref="ElliciumChart" />
    /// </summary>
    public interface IChartAxis
    {
        /// <summary>
        /// Gets or sets the grid lines configuration of this axis.
        /// </summary>
        ElliciumGridLines GridLines { get; set; }
    }
}