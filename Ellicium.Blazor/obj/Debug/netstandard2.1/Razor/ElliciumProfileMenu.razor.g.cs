#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5514aeb823f43135277b3cf752722cdd9d4bc6a6202a1b59b1f35d10192bdd7d"
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
    public partial class ElliciumProfileMenu : ElliciumComponentWithChildren
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                    Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                                        GetCssClass()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "id", 
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                                                            GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "tabindex", "0");
            __builder.AddAttribute(7, "onkeydown", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                  OnKeyPress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(8, "onkeydown", 
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                                        preventKeyPress

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(9, "onkeydown", true);
            __builder.AddElementReferenceCapture(10, (__value) => {
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
               Element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "rz-navigation-item");
            __builder.AddMarkupContent(14, "\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "rz-navigation-item-wrapper");
            __builder.AddAttribute(17, "onclick", "Ellicium.toggleMenuItem(this)");
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "rz-navigation-item-link");
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "item-text");
            __builder.AddEventStopPropagationAttribute(24, "onkeydown", true);
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                         if (Template != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line (13,30)-(13,38) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
__builder.AddContent(26, Template);

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                     
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 16 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                     if (ShowIcon)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                        ");
            __builder.OpenElement(30, "i");
            __builder.AddAttribute(31, "class", "rzi rz-navigation-item-icon-children");
            __builder.AddAttribute(32, "style", 
#nullable restore
#line 18 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                                                iconStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, "keyboard_arrow_down");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 19 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "ul");
            __builder.AddAttribute(39, "class", "rz-navigation-menu");
            __builder.AddAttribute(40, "style", 
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                                   contentStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(41, "onkeydown", true);
            __builder.AddMarkupContent(42, "\n                ");
            global::__Blazor.Ellicium.Blazor.ElliciumProfileMenu.TypeInference.CreateCascadingValue_0(__builder, 43, 44, 
#nullable restore
#line 23 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
                                      this

#line default
#line hidden
#nullable disable
            , 45, (__builder2) => {
                __builder2.AddMarkupContent(46, "\n                    ");
#nullable restore
#line (24,22)-(24,34) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
__builder2.AddContent(47, ChildContent);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(48, "\n                ");
            }
            );
            __builder.AddMarkupContent(49, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 29 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumProfileMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Ellicium.Blazor.ElliciumProfileMenu
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
