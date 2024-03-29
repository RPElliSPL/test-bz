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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class RadzenHtmlEditorImage : ElliciumHtmlEditorButtonBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
       
    protected override async Task OnClick()
    {
        await Editor.SaveSelectionAsync();

        var uploadHeaders = Editor.UploadHeaders ?? new Dictionary<string, string>();

        Attributes = await Editor.GetSelectionAttributes<ImageAttributes>("img", new[] {"src", "alt", "width", "height"});

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
#line (21,21)-(21,31) 25 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
__builder2.AddContent(7, SelectText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\n                ");
            __builder2.OpenElement(9, "ElliciumUpload");
            __builder2.AddAttribute(10, "ChooseText", 
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                            UploadChooseText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(11, "@ref", 
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                                   FileUpload

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(12, "Url", 
#nullable restore
#line 22 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                                                   Editor.UploadUrl

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(13, "Auto", "false");
            __builder2.AddAttribute(14, "Accept", "image/*");
            __builder2.AddAttribute(15, "style", "width: 100%");
            __builder2.AddAttribute(16, "Complete", "OnUploadComplete");
            __builder2.AddAttribute(17, "Error", "OnUploadError");
            __builder2.AddMarkupContent(18, "\n");
#nullable restore
#line 24 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                     foreach (var header in uploadHeaders)
                    {

#line default
#line hidden
#nullable disable
            __builder2.AddContent(19, "                        ");
            __builder2.OpenElement(20, "ElliciumUploadHeader");
            __builder2.AddAttribute(21, "Name", 
#nullable restore
#line 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                    header.Key

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(22, "Value", 
#nullable restore
#line 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                                      header.Value

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(23, "\n");
#nullable restore
#line 27 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(24, "                    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(25, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(26, "\n                ");
            __builder2.OpenElement(27, "div");
            __builder2.AddAttribute(28, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(29, "\n                    ");
            __builder2.OpenElement(30, "label");
#nullable restore
#line (31,29)-(31,38) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
__builder2.AddContent(31, WidthText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(32, "\n                    ");
            __builder2.OpenElement(33, "ElliciumTextBox");
            __builder2.AddAttribute(34, "@bind-Value", 
#nullable restore
#line 32 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                  Attributes.Width

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(35, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(36, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(37, "\n                ");
            __builder2.OpenElement(38, "div");
            __builder2.AddAttribute(39, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(40, "\n                    ");
            __builder2.OpenElement(41, "label");
#nullable restore
#line (35,29)-(35,39) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
__builder2.AddContent(42, HeightText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(43, "\n                    ");
            __builder2.OpenElement(44, "ElliciumTextBox");
            __builder2.AddAttribute(45, "@bind-Value", 
#nullable restore
#line 36 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                  Attributes.Height

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(46, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(47, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(48, "\n                ");
            __builder2.OpenElement(49, "div");
            __builder2.AddAttribute(50, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(51, "\n                    ");
            __builder2.OpenElement(52, "label");
#nullable restore
#line (39,29)-(39,36) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
__builder2.AddContent(53, UrlText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(54, "\n                    ");
            __builder2.OpenElement(55, "ElliciumTextBox");
            __builder2.AddAttribute(56, "@bind-Value", 
#nullable restore
#line 40 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                  Attributes.Src

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(57, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(58, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(59, "\n                ");
            __builder2.OpenElement(60, "div");
            __builder2.AddAttribute(61, "class", "elli-html-editor-dialog-item");
            __builder2.AddMarkupContent(62, "\n                    ");
            __builder2.OpenElement(63, "label");
#nullable restore
#line (43,29)-(43,36) 26 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
__builder2.AddContent(64, AltText);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(65, "\n                    ");
            __builder2.OpenElement(66, "ElliciumTextBox");
            __builder2.AddAttribute(67, "@bind-Value", 
#nullable restore
#line 44 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                                  Attributes.Alt

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(68, "style", "width: 100%");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(69, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(70, "\n                ");
            __builder2.OpenElement(71, "div");
            __builder2.AddAttribute(72, "class", "elli-html-editor-dialog-buttons");
            __builder2.AddMarkupContent(73, "\n                    ");
            __builder2.OpenElement(74, "ElliciumButton");
            __builder2.AddAttribute(75, "Text", 
#nullable restore
#line 47 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                          OkText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(76, "Click", "OnSubmit");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(77, "\n                    ");
            __builder2.OpenElement(78, "ElliciumButton");
            __builder2.AddAttribute(79, "Text", 
#nullable restore
#line 48 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
                                          CancelText

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(80, "Click", "()=> ds.Close(false)");
            __builder2.AddAttribute(81, "ButtonStyle", "ButtonStyle.Secondary");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(82, "\n                ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(83, "\n            ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(84, "\n");
        }
#nullable restore
#line 51 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenHtmlEditorImage.razor"
    );
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
