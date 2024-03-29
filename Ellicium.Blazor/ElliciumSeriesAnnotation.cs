using System;
using Microsoft.AspNetCore.Components;
using Ellicium.Blazor.Rendering;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Displays a text label for the specified data item from the series.
    /// </summary>
    /// <example>
    /// <code>
    ///   &lt;ElliciumChart&gt;
    ///       &lt;ElliciumLineSeries Data=@revenue CategoryProperty="Quarter" ValueProperty="Revenue"&gt;
    ///          &lt;ElliciumSeriesAnnotation Data="@revenue[1] Text="Q2 Revenue" /&gt;
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
    public partial class ElliciumSeriesAnnotation<TItem> : ElliciumChartComponentBase, IChartSeriesOverlay
    {
        /// <summary>
        /// The data item from the series this annotation applies to. 
        /// </summary>
        [Parameter]
        public TItem Data { get; set; }

        /// <summary>
        /// The text to display in the annotation.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary> Horizontal offset from the default position. </summary>
        [Parameter]
        public double OffsetX { get; set; }

        /// <summary> Vertical offset from the default position. </summary>
        [Parameter]
        public double OffsetY { get; set; }

        /// <summary> Determines whether the annotation is visible. Set to <c>true</c> by default.</summary>
        [Parameter]
        public bool Visible { get; set; } = true;

        CartesianSeries<TItem> series;

        /// <summary> The series this annotation applies to. Set to <c>true</c> by default.</summary>
        [CascadingParameter]
        protected CartesianSeries<TItem> Series
        {
            get
            {
                return series;
            }
            set
            {
                if (!value.Overlays.Contains(this))
                {
                    series = value;
                    series.Overlays.Add(this);
                }
            }
        }

        /// <inheritdoc/>
        public RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
        {
            double x = series.TooltipX(Data);
            double y = series.TooltipY(Data);

            var coordinateSystem = series.CoordinateSystem;

            var textAnchor = "middle";

            switch (coordinateSystem)
            {
                case Ellicium.CoordinateSystem.Cartesian:
                    x += OffsetX;
                    y += OffsetY;
                    break;

                case Ellicium.CoordinateSystem.Polar:
                    double orgX;
                    double orgY;
                    if (series is ElliciumPieSeries<TItem>)
                    {
                        var pieSeries = series as ElliciumPieSeries<TItem>;
                        orgX = pieSeries.CenterX;
                        orgY = pieSeries.CenterY;
                    }
                    else
                    {
                        orgX = x;
                        orgY = y;
                    }

                    x -= orgX;
                    y -= orgY;

                    // find angle and add offset
                    var phi = Math.Atan2(y, x);
                    phi += Polar.ToRadian(OffsetY % 360);

                    textAnchor = phi >= -1.5 && phi <= 1.5 ? "start" : "end";

                    // find radius
                    var hyp = Math.Sqrt(x * x + y * y) + OffsetX + 16;

                    // move along the radius and rotate
                    x = orgX + hyp * Math.Cos(phi);
                    y = orgY + hyp * Math.Sin(phi);
                    break;
            }

            return builder => 
            {
                builder.OpenElement(0, "g");
                builder.OpenComponent<Text>(1);
                builder.AddAttribute(2, "Value", Text);
                builder.AddAttribute(3, "Position", new Point{ X = x, Y = y });
                builder.AddAttribute(4, "TextAnchor", textAnchor);
                builder.SetKey($"{Text}-{Chart.Series.IndexOf(series)}");
                builder.CloseComponent();
                builder.CloseElement();
            };
        }

        /// <inheritdoc/>
        protected override bool ShouldRefreshChart(ParameterView parameters)
        {
            return parameters.DidParameterChange(nameof(Visible), Visible);
        }

        /// <inheritdoc/>
        public bool Contains(double mouseX, double mouseY, int tolerance)
        {
            return false;
        }

        /// <inheritdoc/>
        public RenderFragment RenderTooltip(double mouseX, double mouseY, double marginLeft, double marginTop)
        {
            return null;
        }
    }
}