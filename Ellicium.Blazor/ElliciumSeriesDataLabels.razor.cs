﻿using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Displays the series values as text labels.
    /// </summary>
    /// <example>
    /// <code>
    ///   &lt;ElliciumChart&gt;
    ///       &lt;ElliciumLineSeries Data=@revenue CategoryProperty="Quarter" ValueProperty="Revenue"&gt;
    ///          &lt;ElliciumSeriesDataLabels /&gt;
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
    public partial class ElliciumSeriesDataLabels
    {
        /// <summary> Horizontal offset from the default position. </summary>
        [Parameter]
        public double OffsetX { get; set; }

        /// <summary> Vertical offset from the default position. </summary>
        [Parameter]
        public double OffsetY { get; set; }

        /// <summary>Determines the visibility of the data labels. Set to <c>true</c> by default.</summary>
        [Parameter]
        public bool Visible { get; set; } = true;
    }
}