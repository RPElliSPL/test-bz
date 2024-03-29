#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f5a3e629dbeda43517afe72e1d71de4ae7fd102af32b9529c8a495f1eac5a563"
// <auto-generated/>
#pragma warning disable 1591
namespace Ellicium.Blazor
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class ElliciumSeriesValueLine : ElliciumGridLines, IChartSeriesOverlay
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
       
    public ElliciumSeriesValueLine()
    {
        Visible = true;
    }

    [Parameter]
    public virtual double Value { get; set; }

    [Parameter]
    public RenderFragment<double> TooltipTemplate { get; set; }

    IChartSeries series;
    [CascadingParameter]
    protected IChartSeries Series
    {
        get
        {
            return series;
        }
        set
        {
            if (value.CoordinateSystem != CoordinateSystem.Cartesian)
            {
                throw new ArgumentException($"Series must use Cartesian coordinate system");
            }
            series = value;
            if (!series.Overlays.Contains(this))
            {
                series.Overlays.Add(this);
            }
        }
    }

    protected virtual string Name => "Value";

    public RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
    {
        double x1, x2, y1, y2;
        if (Chart.ShouldInvertAxes())
        {
            x1 = x2 = categoryScale.Scale(Value);
            if (x1 < 0 || x1 > Chart.CategoryScale.OutputSize)
            {
                return null;
            }
            y1 = 0; y2 = Chart.ValueScale.OutputSize;
        }
        else
        {
            y1 = y2 = valueScale.Scale(Value);
            if (y1 < 0 || y1 > Chart.ValueScale.OutputSize)
            {
                return null;
            }
            x1 = 0; x2 = Chart.CategoryScale.OutputSize;
        }

        var path = $"M{x1.ToInvariantString()} {y1.ToInvariantString()} L{x2.ToInvariantString()} {y2.ToInvariantString()}";
        return
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "g");
            __builder2.AddMarkupContent(1, "\n        ");
            __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.Path>(2);
            __builder2.AddAttribute(3, "D", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 66 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
                                                                     path

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(4, "Stroke", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 66 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
                                                                                    Stroke

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(5, "StrokeWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 66 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
                                                                                                          StrokeWidth

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(6, "LineType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Ellicium.Blazor.LineType>(
#nullable restore
#line 66 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
                                                                                                                                  LineType

#line default
#line hidden
#nullable disable
            )));
            __builder2.SetKey(
#nullable restore
#line 66 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
                      $"{path}-{Chart.Series.IndexOf(series)}"

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(7, "\n    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\n");
        }
#nullable restore
#line 68 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSeriesValueLine.razor"
    ;
    }

    public bool Contains(double mouseX, double mouseY, int tolerance)
    {
        if (double.IsNaN(Value))
        {
            return false;
        }

        if (Chart.ShouldInvertAxes())
        {
            var a = Chart.CategoryScale.Scale(Value);
            return (mouseY >= -tolerance && mouseY <= Chart.ValueScale.OutputSize + tolerance) && (a >= mouseX - tolerance && a <= mouseX + tolerance);
        }
        else
        {
            var a = Chart.ValueScale.Scale(Value);
            return (mouseX >= -tolerance && mouseX <= Chart.CategoryScale.OutputSize + tolerance) && (a >= mouseY - tolerance && a <= mouseY + tolerance);
        }
    }

    public RenderFragment RenderTooltip(double mouseX, double mouseY, double marginLeft, double marginTop)
    {
        string text;
        if (Chart.ShouldInvertAxes())
        {
            mouseX = Chart.CategoryScale.Scale(Value) + marginLeft;
            mouseY = Math.Max(marginTop, Math.Min(Chart.ValueScale.OutputSize + marginTop, mouseY));
            text = Chart.ValueAxis.Format(Chart.CategoryScale, Value);
        }
        else
        {
            mouseY = Chart.ValueScale.Scale(Value) + marginTop;
            mouseX = Math.Max(marginLeft, Math.Min(Chart.CategoryScale.OutputSize + marginLeft, mouseX));
            text = Chart.ValueAxis.Format(Chart.ValueScale, Value);
        }

        return builder =>
        {
            builder.OpenComponent<ChartTooltip>(0);

            builder.AddAttribute(1, nameof(ChartTooltip.X), mouseX);
            builder.AddAttribute(2, nameof(ChartTooltip.Y), mouseY);

            builder.AddAttribute(3, nameof(ChartTooltip.ChildContent), TooltipTemplate == null ? null : TooltipTemplate(Value));

            builder.AddAttribute(8, nameof(ChartTooltip.Title), series.GetTitle());
            builder.AddAttribute(4, nameof(ChartTooltip.Label), Name);
            builder.AddAttribute(5, nameof(ChartTooltip.Value), text);

            builder.AddAttribute(6, nameof(ChartTooltip.Style), $"border: 1px solid {Stroke};");
            builder.AddAttribute(7, nameof(ChartTooltip.Class), "");

            builder.CloseComponent();
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
