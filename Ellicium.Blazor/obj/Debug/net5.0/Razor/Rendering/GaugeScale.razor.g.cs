#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85c56ea58c9cbd03a94a2be94dc2b12a9381ca72d5ed36ba4c5b06cd432d20f8"
// <auto-generated/>
#pragma warning disable 1591
namespace Ellicium.Blazor.Rendering
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
using Ellicium.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class GaugeScale : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", "rz-line");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.Path>(3);
            __builder.AddAttribute(4, "D", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
             Path

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Stroke", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                          Stroke

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "StrokeWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                              StrokeWidth

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Fill", (object)("none"));
            __builder.AddAttribute(8, "Class", (object)("rz-scale-line"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
 foreach (var tick in Ticks)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "g");
            __builder.AddAttribute(13, "class", "rz-tick");
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.Path>(15);
            __builder.AddAttribute(16, "Class", (object)("rz-tick-line"));
            __builder.AddAttribute(17, "D", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                      tick.Path

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "Stroke", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                                        Stroke

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "StrokeWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                                                            StrokeWidth

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "Fill", (object)("none"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n        if (!string.IsNullOrEmpty(tick.Value))\n        {\n            ");
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.Text>(22);
            __builder.AddAttribute(23, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                         tick.Value

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "Class", (object)("rz-tick-text"));
            __builder.AddAttribute(25, "Position", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Ellicium.Blazor.Point>(
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                                                   tick.Text

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n        }\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 16 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
 foreach (var tick in MinorTicks)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "g");
            __builder.AddAttribute(30, "class", "rz-tick rz-minor-tick");
            __builder.AddMarkupContent(31, "\n        ");
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.Path>(32);
            __builder.AddAttribute(33, "Class", (object)("rz-tick-line"));
            __builder.AddAttribute(34, "D", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                      tick.Path

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(35, "Stroke", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                                        Stroke

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "StrokeWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
                                                                            StrokeWidth

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "Fill", (object)("none"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\GaugeScale.razor"
       
    [Parameter]
    public double StartAngle { get; set; }

    [Parameter]
    public string Stroke { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public double TickLength { get; set; }

    [Parameter]
    public double MinorTickLength { get; set; }

    [Parameter]
    public double TickLabelOffset { get; set; }

    [Parameter]
    public double EndAngle { get; set; }

    [Parameter]
    public double Radius { get; set; }

    [Parameter]
    public Point Center { get; set; }

    [Parameter]
    public double Min { get; set; }

    [Parameter]
    public double Max { get; set; }

    [Parameter]
    public bool ShowFirstTick { get; set; }

    [Parameter]
    public bool ShowLastTick { get; set; }

    [Parameter]
    public bool ShowTickLabels { get; set; }

    [Parameter]
    public GaugeTickPosition TickPosition { get; set; }

    [Parameter]
    public string FormatString { get; set; }

    [Parameter]
    public Func<double, string> Formatter { get; set; }

    [Parameter]
    public double Step { get; set; }

    [Parameter]
    public double MinorStep { get; set; }

    private string Path { get; set; }

    class Tick
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Point Text { get; set; }

        public string Value { get; set; }
        public string Path
        {
            get
            {
                return $"M {Start.Render()} L {End.Render()}";
            }
        }
    }

    private IList<Tick> Ticks { get; set; }
    private IList<Tick> MinorTicks { get; set; }

    protected override void OnParametersSet()
    {
        var startAngle = Polar.ToRadian(StartAngle - 90);
        var start = Center.ToCartesian(Radius, startAngle);

        var endAngle = Polar.ToRadian(EndAngle - 90);

        var end = Center.ToCartesian(Radius, endAngle);

        var sweep = EndAngle - StartAngle <= 180 ? 0 : 1;

        if (Math.Abs(end.X - start.X) < 0.01 && Math.Abs(end.Y - start.Y) < 0.01)
        {
            // Full circle - SVG can't render a full circle arc 
            end.X = end.X - 0.01;
        }

        Path = $"M {start.Render()} A {Radius.ToInvariantString()} {Radius.ToInvariantString()} 0 {sweep} 1 {end.Render()}";

        Ticks = new List<Tick>();
        MinorTicks = new List<Tick>();

        if (TickPosition != GaugeTickPosition.None)
        {
            var count = Math.Floor((Max - Min) / Step);
            var step = Polar.ToRadian(EndAngle - StartAngle) / count;
            var angle = startAngle;
            var value = Min;

            for (var idx = 0; idx <= count; idx++)
            {
                var tick = new Tick();

                if (ShowTickLabels)
                {
                    if (!string.IsNullOrEmpty(FormatString))
                    {
                        tick.Value = string.Format(FormatString, value);
                    }
                    else
                    {
                        tick.Value = Formatter(value);
                    }
                }

                if (TickPosition == GaugeTickPosition.Outside)
                {
                    tick.Start = Center.ToCartesian(Radius, angle);
                    tick.End = Center.ToCartesian(Radius + TickLength, angle);
                    tick.Text = Center.ToCartesian(Radius + TickLabelOffset, angle);
                }

                if (TickPosition == GaugeTickPosition.Inside)
                {
                    tick.Start = Center.ToCartesian(Radius - TickLength, angle);
                    tick.End = Center.ToCartesian(Radius, angle);
                    tick.Text = Center.ToCartesian(Radius - TickLabelOffset, angle);
                }

                angle += step;
                value += Step;

                if (idx == 0 && ShowFirstTick == false)
                {
                    continue;
                }

                if (idx == count && ShowLastTick == false)
                {
                    continue;
                }

                Ticks.Add(tick);
            }

            if (MinorStep > 0)
            {
                var minorCount = Math.Floor((Max - Min) / MinorStep);
                var minorStep = Polar.ToRadian(EndAngle - StartAngle) / minorCount;
                var minorAngle = startAngle;

                for (var idx = 0; idx <= minorCount; idx++)
                {
                    var tick = new Tick();

                    if (TickPosition == GaugeTickPosition.Outside)
                    {
                        tick.Start = Center.ToCartesian(Radius, minorAngle);
                        tick.End = Center.ToCartesian(Radius + MinorTickLength, minorAngle);
                    }

                    if (TickPosition == GaugeTickPosition.Inside)
                    {
                        tick.Start = Center.ToCartesian(Radius - MinorTickLength, minorAngle);
                        tick.End = Center.ToCartesian(Radius, minorAngle);
                    }

                    minorAngle += minorStep;

                    if (idx % (Step / MinorStep) == 0)
                    {
                        continue;
                    }

                    MinorTicks.Add(tick);
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
