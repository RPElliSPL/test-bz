#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a89eb6c504707ab66ff59b1eb03371c388e0c3dc26fd94eadf83254508440c84"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class ElliciumSplitter : ElliciumComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddMultipleAttributes(2, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                                      Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                                                          GetCssClass()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "id", 
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                                                                              GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "style", 
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                                                                                               Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                Element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            global::__Blazor.Ellicium.Blazor.ElliciumSplitter.TypeInference.CreateCascadingValue_0(__builder, 8, 9, 
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
                              this

#line default
#line hidden
#nullable disable
            , 10, (__builder2) => {
                __builder2.AddMarkupContent(11, "\n            ");
#nullable restore
#line (9,14)-(9,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
__builder2.AddContent(12, ChildContent);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(13, "\n        ");
            }
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumSplitter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Ellicium.Blazor.ElliciumSplitter
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
