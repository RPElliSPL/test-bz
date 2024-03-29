namespace  Ellicium.Blazor.Rendering
{
    /// <summary>
    /// Represents a data label in ElliciumChart.
    /// </summary>
   public class ChartDataLabel 
   {
        /// <summary>
        /// The position of the label.
        /// </summary>
        public Point Position { get; set; }
        /// <summary>
        /// The text of the label.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The text anchor of the label.
        /// </summary>
        public string TextAnchor { get; set; }
   }
}