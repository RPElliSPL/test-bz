#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c86a9ba1a79bf51bb931b1dbdc2abf66be4975b50592331272557c7ced583570"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
using Ellicium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class ElliciumNumeric<
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
TValue

#line default
#line hidden
#nullable disable
    > : FormComponentWithAutoComplete<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                  Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                      Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                          GetCssClass()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "id", 
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                              GetId()

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                 Element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddMultipleAttributes(9, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                          InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "inputmode", "decimal");
            __builder.AddAttribute(12, "name", 
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                  Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "disabled", 
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                                   Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "readonly", 
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                                                        ReadOnly

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", 
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                       GetInputCssClass()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "tabindex", 
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                       Disabled ? "-1" : $"{TabIndex}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "id", 
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                              Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "placeholder", 
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                             CurrentPlaceholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "autocomplete", 
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                AutoCompleteAttribute

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "aria-autocomplete", 
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                           AriaAutoCompleteAttribute

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                                                              FormattedValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                                                                                          OnChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onkeypress", "Ellicium.numericKeyPress(event," + " " + (
#nullable restore
#line 14 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                            IsInteger().ToString().ToLower()

#line default
#line hidden
#nullable disable
            ) + "," + " \'" + (
#nullable restore
#line 14 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                                CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.AddAttribute(24, "onblur", 
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                        getOnInput()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "onpaste", 
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                getOnPaste()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onkeydown", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                             args => OnKeyPress(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(27, "onkeydown", 
#nullable restore
#line 16 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                                                                  preventKeyPress

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(28, "onkeydown", true);
            __builder.AddElementReferenceCapture(29, (__value) => {
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                      input = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n");
#nullable restore
#line 18 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
         if (ShowUpDown)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "rz-spinner-button rz-spinner-up rz-button");
            __builder.AddAttribute(35, "tabindex", "-1");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                (args) => UpdateValueWithStep(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\n                <span class=\"rz-spinner-button-icon rzi rzi-caret-up\"></span>\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "rz-spinner-button rz-spinner-down rz-button");
            __builder.AddAttribute(42, "tabindex", "-1");
            __builder.AddAttribute(43, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
                                (args) => UpdateValueWithStep(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\n                <span class=\"rz-spinner-button-icon rzi rzi-caret-down\"></span>\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 28 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#nullable restore
#line 30 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNumeric.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
