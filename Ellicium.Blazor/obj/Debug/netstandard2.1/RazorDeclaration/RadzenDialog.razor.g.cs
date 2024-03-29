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
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDialog.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDialog.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class RadzenDialog : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDialog.razor"
       
    [Inject] 
    DialogService Service { get; set; }

    /// <summary>
    /// Gets or sets the close side dialog aria label text.
    /// </summary>
    /// <value>The close side dialog aria label text.</value>
    [Parameter]
    public string CloseSideDialogAriaLabel { get; set; } = "Close side dialog";

    List<Dialog> dialogs = new List<Dialog>();
    bool isSideDialogOpen = false;
    RenderFragment sideDialogContent;
    SideDialogOptions sideDialogOptions;

    public async Task Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        dialogs.Add(new Dialog() { Title = title, Type = type, Parameters = parameters, Options = options });

        await InvokeAsync(() => { StateHasChanged(); });
    }

    public async Task Close(dynamic result)
    {
        var lastDialog = dialogs.LastOrDefault();
        if (lastDialog != null)
        {
            dialogs.Remove(lastDialog);
            if (dialogs.Count==0) await JSRuntime.InvokeAsync<string>("Ellicium.closeDialog");
        }

        await InvokeAsync(() => 
        { 
            StateHasChanged(); 
        });
    }

    public void Dispose()
    {
        Service.OnOpen -= OnOpen;
        Service.OnClose -= OnClose;

        Service.OnSideOpen -= OnSideOpen;
        Service.OnSideClose -= OnSideClose;
    }

    protected override void OnInitialized()
    {
        Service.OnOpen += OnOpen;
        Service.OnClose += OnClose;

        Service.OnSideOpen += OnSideOpen;
        Service.OnSideClose += OnSideClose;
    }

    void OnSideOpen(Type sideComponent, Dictionary<string, object> parameters, SideDialogOptions options)
    {
        sideDialogOptions = options;
        sideDialogContent = new RenderFragment(builder =>
        {
            builder.OpenComponent(0, sideComponent);
            foreach (var parameter in parameters)
            {
                builder.AddAttribute(1, parameter.Key, parameter.Value);
            }
            builder.CloseComponent();
        });
        isSideDialogOpen = true;
        StateHasChanged();
    }

    void OnSideClose(dynamic _)
    {
        isSideDialogOpen = false;
        StateHasChanged();
    }

    void OnOpen(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        Open(title, type, parameters, options).ConfigureAwait(false);
    }

    void OnClose(dynamic result)
    {
        Close(result).ConfigureAwait(false);
    }

    string GetSideDialogCssClass()
    {
        return $"elli-dialog-side elli-dialog-side-position-{sideDialogOptions.Position.ToString().ToLower()} {sideDialogOptions.CssClass}";
    }

    string GetSideDialogStyle()
    {
        string widthStyle = string.IsNullOrEmpty(sideDialogOptions.Width) ? string.Empty : $"width: {sideDialogOptions.Width};";
        string heightStyle = string.IsNullOrEmpty(sideDialogOptions.Height) ? string.Empty : $"height: {sideDialogOptions.Height};";

        return $"{widthStyle}{heightStyle}{sideDialogOptions.Style}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
