#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3e55eab9ecb16598aafc625004db6819f0a6c7e83f0d596e4d986761ba90f29b"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class ElliciumHtmlEditorFontSize : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDown>(0);
            __builder.AddAttribute(1, "Title", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor"
                       Title

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor"
                                    Editor.State.FontSize

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Change", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor"
                                                                  OnChange

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "Placeholder", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFontSize.razor"
                                                                                         Placeholder

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(7);
                __builder2.AddAttribute(8, "Text", (object)("10px"));
                __builder2.AddAttribute(9, "Value", (object)("1"));
                __builder2.AddAttribute(10, "style", (object)("font-size: x-small"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(12);
                __builder2.AddAttribute(13, "Text", (object)("13px"));
                __builder2.AddAttribute(14, "Value", (object)("2"));
                __builder2.AddAttribute(15, "style", (object)("font-size: small"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(17);
                __builder2.AddAttribute(18, "Text", (object)("16px"));
                __builder2.AddAttribute(19, "Value", (object)("3"));
                __builder2.AddAttribute(20, "style", (object)("font-size: medium"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(22);
                __builder2.AddAttribute(23, "Text", (object)("18px"));
                __builder2.AddAttribute(24, "Value", (object)("4"));
                __builder2.AddAttribute(25, "style", (object)("font-size: large"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(27);
                __builder2.AddAttribute(28, "Text", (object)("24px"));
                __builder2.AddAttribute(29, "Value", (object)("5"));
                __builder2.AddAttribute(30, "style", (object)("font-size: x-large"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(32);
                __builder2.AddAttribute(33, "Text", (object)("32px"));
                __builder2.AddAttribute(34, "Value", (object)("6"));
                __builder2.AddAttribute(35, "style", (object)("font-size: xx-large"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(37);
                __builder2.AddAttribute(38, "Text", (object)("48px"));
                __builder2.AddAttribute(39, "Value", (object)("7"));
                __builder2.AddAttribute(40, "style", (object)("font-size: -webkit-xxx-large; font-size: xxx-large"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
