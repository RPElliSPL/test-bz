#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a49f0d561b72b1cb899a49dc0229bad13e0be9a2c986e816abb9d4ea6c2e33f"
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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class ElliciumHtmlEditorFormatBlock : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDown>(0);
            __builder.AddAttribute(1, "Title", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                       Title

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                                    Editor.State.FormatBlock

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Change", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                                                                     OnChange

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "Placeholder", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                                                                                            Placeholder

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "PopupStyle", (object)("width: 200px; max-height: 200px; overflow: auto;"));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(8);
                __builder2.AddAttribute(9, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              NormalText

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Value", (object)("p"));
                __builder2.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(12, "\n        ");
                    __builder3.OpenElement(13, "p");
                    __builder3.AddAttribute(14, "style", "margin:0");
#nullable restore
#line (6,30)-(6,42) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(15, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(16, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(18);
                __builder2.AddAttribute(19, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading1Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Value", (object)("h1"));
                __builder2.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(22, "\n        ");
                    __builder3.OpenElement(23, "h1");
#nullable restore
#line (9,14)-(9,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(24, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(27);
                __builder2.AddAttribute(28, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading2Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Value", (object)("h2"));
                __builder2.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(31, "\n        ");
                    __builder3.OpenElement(32, "h2");
#nullable restore
#line (12,14)-(12,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(33, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(36);
                __builder2.AddAttribute(37, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 14 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading3Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(38, "Value", (object)("h3"));
                __builder2.AddAttribute(39, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\n        ");
                    __builder3.OpenElement(41, "h3");
#nullable restore
#line (15,14)-(15,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(42, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(45);
                __builder2.AddAttribute(46, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading4Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "Value", (object)("h4"));
                __builder2.AddAttribute(48, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\n        ");
                    __builder3.OpenElement(50, "h4");
#nullable restore
#line (18,14)-(18,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(51, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(54);
                __builder2.AddAttribute(55, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading5Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(56, "Value", (object)("h5"));
                __builder2.AddAttribute(57, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(58, "\n        ");
                    __builder3.OpenElement(59, "h5");
#nullable restore
#line (21,14)-(21,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(60, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenComponent<global::Ellicium.Blazor.Rendering.EditorDropDownItem>(63);
                __builder2.AddAttribute(64, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
                              Heading6Text

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(65, "Value", (object)("h6"));
                __builder2.AddAttribute(66, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Ellicium.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\n        ");
                    __builder3.OpenElement(68, "h6");
#nullable restore
#line (24,14)-(24,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumHtmlEditorFormatBlock.razor"
__builder3.AddContent(69, context.Text);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
