#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a2ee51a97d715a92293b339e19917bc926dbcf592c7f9a8f7831c6394b323b58"
// <auto-generated/>
#pragma warning disable 1591
namespace Ellicium.Blazor
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class ElliciumRating : FormComponent<int>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                   Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                       GetCssClass()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "id", 
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                                           GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 6 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                Element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
         if (!ReadOnly)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "aria-label", 
#nullable restore
#line 9 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                            ClearAriaLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                        args => SetValue(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(12, "onclick", 
#nullable restore
#line 9 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "rz-rating-cancel");
            __builder.AddAttribute(14, "tabindex", 
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                            Disabled ? "-1" : $"{TabIndex}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onkeypress", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                               args => OnKeyPress(args, SetValue(0))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(16, "onkeypress", 
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                                                  preventKeyPress

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(17, "onkeypress", true);
            __builder.AddMarkupContent(18, "\n                <span class=\"rz-rating-icon rzi rzi-ban\"></span>\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 14 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
         foreach (var index in Enumerable.Range(1, Stars))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "aria-label", 
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                            RateAriaLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                       args => SetValue(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(24, "onclick", 
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "tabindex", 
#nullable restore
#line 18 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                            Disabled ? "-1" : $"{TabIndex}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onkeypress", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                              args => OnKeyPress(args, SetValue(index))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(27, "onkeypress", 
#nullable restore
#line 19 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                                                                     preventKeyPress

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(28, "onkeypress", true);
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "rz-rating-icon" + " rzi" + " " + (
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
                                                  index <= Value ? "rzi-star": "rzi-star-o"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 24 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumRating.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
