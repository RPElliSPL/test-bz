// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ellicium.Blazor
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class RadzenHtmlEditorLink : ElliciumHtmlEditorButtonBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
       
    protected override async Task OnClick()
    {
        await Editor.SaveSelectionAsync();

        bool blank = false;

        var attributes = await Editor.GetSelectionAttributes<LinkAttributes>("a", new[] {"innerText", "href", "target" });

        if (attributes.Target == "_blank")
        {
            blank = true;
        }

        var result = await DialogService.OpenAsync(Title, ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "div");
            __builder2.AddAttribute(1, "class", "elli-html-editor-dialog");
            __builder2.AddMarkupContent(2, "\n        ");
            __builder2.OpenElement(3, "div");
            __builder2.AddAttribute(4, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(5, "\n            ");
            __builder2.OpenElement(6, "label");
#nullable restore
#line (26,21)-(26,28) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
__builder2.AddContent(7, UrlText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\n            ");
            __builder2.OpenElement(9, "ElliciumTextBox");
            __builder2.AddAttribute(10, "@bind-Value", 
#nullable restore
#line 27 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                          attributes.Href

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(11, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(13, "\n");
#nullable restore
#line 29 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
         if (string.IsNullOrWhiteSpace(attributes.InnerHtml) || attributes.InnerHtml == "<br>")
        {

#line default
#line hidden
#nullable disable
            __builder2.AddContent(14, "        ");
            __builder2.OpenElement(15, "div");
            __builder2.AddAttribute(16, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(17, "\n            ");
            __builder2.OpenElement(18, "label");
#nullable restore
#line (32,21)-(32,29) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
__builder2.AddContent(19, LinkText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(20, "\n            ");
            __builder2.OpenElement(21, "ElliciumTextBox");
            __builder2.AddAttribute(22, "@bind-Value", 
#nullable restore
#line 33 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                          attributes.InnerText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(23, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(24, "\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(25, "\n");
#nullable restore
#line 35 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
        }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(26, "        ");
            __builder2.OpenElement(27, "div");
            __builder2.AddAttribute(28, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(29, "\n            ");
            __builder2.OpenElement(30, "ElliciumCheckBox");
            __builder2.AddAttribute(31, "@bind-Value", 
#nullable restore
#line 37 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                           blank

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(32, "\n            ");
            __builder2.OpenElement(33, "label");
#nullable restore
#line (38,21)-(38,40) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
__builder2.AddContent(34, OpenInNewWindowText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(35, "\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(36, "\n        ");
            __builder2.OpenElement(37, "div");
            __builder2.AddAttribute(38, "class", "elli-html-editor-dialog-buttons");
            __builder2.AddMarkupContent(39, "\n            ");
            __builder2.OpenElement(40, "ElliciumButton");
            __builder2.AddAttribute(41, "Text", 
#nullable restore
#line 41 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                  OkText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(42, "Click", "()=> ds.Close(true)");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(43, "\n            ");
            __builder2.OpenElement(44, "ElliciumButton");
            __builder2.AddAttribute(45, "Text", 
#nullable restore
#line 42 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
                                  CancelText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(46, "Click", "()=> ds.Close(false)");
            __builder2.AddAttribute(47, "ButtonStyle", "ButtonStyle.Secondary");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(48, "\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(49, "\n    ");
            __builder2.CloseElement();
        }
#nullable restore
#line 44 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorLink.razor"
          );

        await Editor.RestoreSelectionAsync();

        if (result == true && !String.IsNullOrEmpty(attributes.Href))
        {
            var html = new StringBuilder();
            html.AppendFormat("<a href=\"{0}\"", attributes.Href);
            if (blank)
            {
                html.Append(" target=\"_blank\"");
            }

            html.AppendFormat(">{0}</a>", string.IsNullOrEmpty(attributes.InnerText) ? attributes.InnerHtml : attributes.InnerText);

            await Editor.ExecuteCommandAsync("insertHTML", html.ToString());
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
