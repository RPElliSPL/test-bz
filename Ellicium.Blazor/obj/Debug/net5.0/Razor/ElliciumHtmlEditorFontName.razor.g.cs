#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "561f03e24c317f3434e6d9d2ce6c943ea352bc885c7c25e94cefe17a59d86ba5"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class ElliciumHtmlEditorFontName : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDown>(0);
            __builder.AddAttribute(1, "Title", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                       Title

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                                    Editor.State.FontName

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Change", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                                                                  OnChange

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "Placeholder", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                                                                                         Placeholder

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "PopupStyle", (object)("width: 200px; max-height: 200px; overflow: auto;"));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\n    ");
                global::__Blazor.Ellicium.Blazor.ElliciumHtmlEditorFontName.TypeInference.CreateCascadingValue_0(__builder2, 8, 9, 
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                           this

#line default
#line hidden
#nullable disable
                , 10, (__builder3) => {
                    __builder3.AddMarkupContent(11, "\n");
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
         if (ChildContent != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line (8,14)-(8,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
__builder3.AddContent(12, ChildContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
                         
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(13, "            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(14);
                    __builder3.AddAttribute(15, "Text", (object)("Arial"));
                    __builder3.AddAttribute(16, "Value", (object)("Arial"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(18);
                    __builder3.AddAttribute(19, "Text", (object)("Georgia"));
                    __builder3.AddAttribute(20, "Value", (object)("Georgia"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(22);
                    __builder3.AddAttribute(23, "Text", (object)("Helvetica"));
                    __builder3.AddAttribute(24, "Value", (object)("Helvetica"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(26);
                    __builder3.AddAttribute(27, "Text", (object)("Monospace"));
                    __builder3.AddAttribute(28, "Value", (object)("monospace"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(30);
                    __builder3.AddAttribute(31, "Text", (object)("Segoe UI"));
                    __builder3.AddAttribute(32, "Value", (object)("\"Segoe UI\""));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(34);
                    __builder3.AddAttribute(35, "Text", (object)("Tahoma"));
                    __builder3.AddAttribute(36, "Value", (object)("Tahoma"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(38);
                    __builder3.AddAttribute(39, "Text", (object)("Times New Roman"));
                    __builder3.AddAttribute(40, "Value", (object)("\"Times New Roman\""));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<global::Ellicium.Blazor.ElliciumHtmlEditorFontNameItem>(42);
                    __builder3.AddAttribute(43, "Text", (object)("Verdana"));
                    __builder3.AddAttribute(44, "Value", (object)("Verdana"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n");
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontName.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "    ");
                }
                );
                __builder2.AddMarkupContent(47, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Ellicium.Blazor.ElliciumHtmlEditorFontName
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
