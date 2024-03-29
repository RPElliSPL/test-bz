#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2350543160fbe6655ba7b30a984991626c645a3dfc421cd55ed2e74c91a11783"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
using Ellicium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
using Ellicium.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class ElliciumBarSeries<
#nullable restore
#line 4 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
TItem

#line default
#line hidden
#nullable disable
    > : Ellicium.Blazor.CartesianSeries<TItem>, IChartBarSeries
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.Ellicium.Blazor.ElliciumBarSeries.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                        this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n  ");
#nullable restore
#line (9,4)-(9,16) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
__builder2.AddContent(4, ChildContent);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(5, "\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
       
    public override RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
    {
        var value = ComposeValue(categoryScale);
        var category = ComposeCategory(valueScale);
        var ticks = Chart.CategoryScale.Ticks(Chart.ValueAxis.TickDistance);
        var x0 = Chart.CategoryScale.Scale(Math.Max(0, ticks.Start));
        var style = $"clip-path: url(#{Chart.ClipPath}); -webkit-clip-path: url(#{Chart.ClipPath});";

        var barSeries = VisibleBarSeries;
        var index = barSeries.IndexOf(this);
        var padding = Chart.BarOptions.Margin;

        var barHeight = BandHeight;
        var height = barHeight / barSeries.Count() - padding + padding / barSeries.Count();;
        var className = $"rz-bar-series rz-series-{Chart.Series.IndexOf(this)}";

        return
        

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(6, "g");
            __builder2.AddAttribute(7, "class", 
#nullable restore
#line 30 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                    className

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(8, "\n");
#nullable restore
#line 31 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
             foreach(var data in Items)
            {
                var y = category(data) - barHeight / 2 + index * height + index * padding;
                var x = value(data);
                var itemValue = Value(data);                
                var radius = Chart.BarOptions.Radius;

                if (radius > height / 2)
                {
                    radius = 0;
                }

                var r = radius.ToInvariantString();

                var path = $"M {x0.ToInvariantString()} {y.ToInvariantString()} L {(x-radius).ToInvariantString()} {y.ToInvariantString()} A {r} {r} 0 0 1 {x.ToInvariantString()} {(y+radius).ToInvariantString()} L {x.ToInvariantString()} {(y+height-radius).ToInvariantString()} A {r} {r} 0 0 1 {(x-radius).ToInvariantString()} {(y + height).ToInvariantString()} L {x0.ToInvariantString()} {(y+height).ToInvariantString()} Z";

                if (x < x0)
                {
                    path = $"M {x0.ToInvariantString()} {y.ToInvariantString()} L {(x+radius).ToInvariantString()} {y.ToInvariantString()} A {r} {r} 0 0 0 {x.ToInvariantString()} {(y+radius).ToInvariantString()} L {x.ToInvariantString()} {(y+height-radius).ToInvariantString()} A {r} {r} 0 0 0 {(x+radius).ToInvariantString()} {(y + height).ToInvariantString()} L {x0.ToInvariantString()} {(y+height).ToInvariantString()} Z";
                }
                var fill = PickColor(Items.IndexOf(data), Fills, Fill, FillRange, itemValue);
                var stroke = PickColor(Items.IndexOf(data), Strokes, Stroke, StrokeRange, itemValue);


#line default
#line hidden
#nullable disable
            __builder2.AddContent(9, "                ");
            __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.Path>(10);
            __builder2.AddAttribute(11, "D", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                       path

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(12, "Stroke", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                                      stroke

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(13, "StrokeWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                                                            StrokeWidth

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(14, "Fill", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                                                                                fill

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(15, "LineType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Ellicium.Blazor.LineType>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                                                                                                 LineType

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(16, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                                                                                                                                   style

#line default
#line hidden
#nullable disable
            )));
            __builder2.SetKey(
#nullable restore
#line 54 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
                             path

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(17, "\n");
#nullable restore
#line 55 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
            }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(18, "        ");
            __builder2.CloseElement();
        }
#nullable restore
#line 56 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumBarSeries.razor"
            ;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Ellicium.Blazor.ElliciumBarSeries
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
