namespace Ellicium.Blazor
{
    /// <summary>
    /// Displays the trend of a chart series.
    /// </summary>
    /// <example>
    /// <code>
    ///   &lt;ElliciumChart&gt;
    ///       &lt;ElliciumLineSeries Data=@revenue CategoryProperty="Quarter" ValueProperty="Revenue"&gt;
    ///          &lt;ElliciumSeriesTrendLine /&gt;
    ///       &lt;/ElliciumLineSeries&gt;
    ///   &lt;/ElliciumChart&gt;
    ///   @code {
    ///       class DataItem
    ///       {
    ///           public string Quarter { get; set; }
    ///           public double Revenue { get; set; }
    ///       }
    ///       DataItem[] revenue = new DataItem[]
    ///       {
    ///           new DataItem { Quarter = "Q1", Revenue = 234000 },
    ///           new DataItem { Quarter = "Q2", Revenue = 284000 },
    ///           new DataItem { Quarter = "Q3", Revenue = 274000 },
    ///           new DataItem { Quarter = "Q4", Revenue = 294000 }
    ///       };
    ///   }
    /// </code>
    /// </example>
    public partial class ElliciumSeriesTrendLine
    {
    }
}