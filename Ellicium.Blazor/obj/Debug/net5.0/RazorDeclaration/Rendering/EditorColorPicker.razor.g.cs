// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ellicium.Blazor.Rendering
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Rishabh\Blazor-test-bz\test-bz\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class EditorColorPicker : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Rishabh\Blazor-test-bz\test-bz\Ellicium.Blazor\Rendering\EditorColorPicker.razor"
       
    [CascadingParameter]
    public ElliciumHtmlEditor Editor { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public string IconColor { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public HtmlEditorMode EnabledModes { get; set; } = HtmlEditorMode.Design;

    [Parameter]
    public bool ShowHSV { get; set; } = true;

    [Parameter]
    public bool ShowRGBA { get; set; } = true;

    [Parameter]
    public bool ShowColors { get; set; } = true;

    [Parameter]
    public bool ShowButton { get; set; } = true;

    [Parameter]
    public string HexText { get; set; } = "Hex";

    [Parameter]
    public string RedText { get; set; } = "R";

    [Parameter]
    public string GreenText { get; set; } = "G";

    [Parameter]
    public string BlueText { get; set; } = "B";

    [Parameter]
    public string AlphaText { get; set; } = "A";

    [Parameter]
    public string ButtonText { get; set; } = "OK";

    [Parameter]
    public EventCallback<string> Change { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    async Task OnChange(string value)
    {
        await Editor.RestoreSelectionAsync();
        await ValueChanged.InvokeAsync(value);
        await Change.InvokeAsync(value);
    }

    async Task OnOpen()
    {
        await Editor.SaveSelectionAsync();
    }

    async Task OnClick()
    {
        await Change.InvokeAsync(Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
