#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61959b7c8e8abae6fcccd6f8826f5a9a183fdad95866e9e6a2d72f41de11e31f"
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
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class EditorDropDown : ElliciumComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "title", 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
            Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                       Class

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                       Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(4, "onmousedown", true);
            __builder.AddMultipleAttributes(5, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                                                                       Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "disabled", 
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                                                                                             Editor.Disabled || !EnabledModes.HasFlag(Editor.GetMode())

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                        Element = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "rz-html-editor-dropdown-value");
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
         if (SelectedItem != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line (7,14)-(7,31) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
__builder.AddContent(12, SelectedItem.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                              
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line (11,14)-(11,25) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
__builder.AddContent(13, Placeholder);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                        
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddEventPreventDefaultAttribute(17, "onclick", true);
            __builder.AddAttribute(18, "tabindex", "-1");
            __builder.AddAttribute(19, "class", "rz-html-editor-dropdown-trigger");
            __builder.AddAttribute(20, "disabled", 
#nullable restore
#line 14 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                                                                     Editor.Disabled || !EnabledModes.HasFlag(Editor.GetMode())

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "<i class=\"rzi\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenComponent<global::Ellicium.Blazor.Rendering.Popup>(23);
            __builder.AddAttribute(24, "class", (object)("rz-html-editor-dropdown-items"));
            __builder.AddAttribute(25, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                                   PopupStyle

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "PreventDefault", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\n        ");
                global::__Blazor.Ellicium.Blazor.Rendering.EditorDropDown.TypeInference.CreateCascadingValue_0(__builder2, 29, 30, 
#nullable restore
#line 16 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                               this

#line default
#line hidden
#nullable disable
                , 31, (__builder3) => {
                    __builder3.AddMarkupContent(32, "\n            ");
#nullable restore
#line (17,14)-(17,26) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
__builder3.AddContent(33, ChildContent);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(34, "\n        ");
                }
                );
                __builder2.AddMarkupContent(35, "\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 15 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
                Popup = (Ellicium.Blazor.Rendering.Popup)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\EditorDropDown.razor"
       
    [CascadingParameter]
    public ElliciumHtmlEditor Editor { get; set; }

    Popup Popup { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string PopupStyle { get; set; }

    [Parameter]
    public string Placeholder { get; set; }

    [Parameter]
    public HtmlEditorMode EnabledModes { get; set; } = HtmlEditorMode.Design;

    async Task Toggle()
    {
        if (!Editor.Disabled && EnabledModes.HasFlag(Editor.GetMode()))
        {
            await Popup.ToggleAsync(Element);
        }
    }

    [Parameter]
    public string Value { get; set; }

    internal EditorDropDownItem SelectedItem { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public EventCallback<string> Change { get; set; }

    internal async Task Select(EditorDropDownItem item, bool change)
    {
        if (SelectedItem != item && !Editor.Disabled && EnabledModes.HasFlag(Editor.GetMode()))
        {
            SelectedItem = item;

            if (change)
            {
                await Popup.CloseAsync();
                await ValueChanged.InvokeAsync(item?.Value);
                await Change.InvokeAsync(item?.Value);
            }

            StateHasChanged();
        }
    }

    string Class
    {
        get
        {
            var classList = new List<string>() { "rz-html-editor-dropdown" };

            if (Editor.Disabled || !EnabledModes.HasFlag(Editor.GetMode()))
            {
                classList.Add("rz-disabled");
            }

            return string.Join(" ", classList);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Ellicium.Blazor.Rendering.EditorDropDown
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
