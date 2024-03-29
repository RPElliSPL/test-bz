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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumTooltip.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class ElliciumTooltip : global::Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumTooltip.razor"
       
    string getCssClass(Tooltip tooltip)
    {
        return $"rz-{Enum.GetName(typeof(TooltipPosition), tooltip.Options.Position).ToLowerInvariant()}-tooltip-content";
    }

    public string UniqueID { get; set; }

    [Inject] private TooltipService Service { get; set; }

    List<Tooltip> tooltips = new List<Tooltip>();

    public async Task Open(ElementReference element, Type type, TooltipOptions options)
    {
        tooltips.Clear();
        tooltips.Add(new Tooltip() { Type = type, Options = options, Element = element });

        await InvokeAsync(() => { StateHasChanged(); });

        var tooltip = tooltips.LastOrDefault();

        if (tooltip != null)
        {
            await JSRuntime.InvokeVoidAsync("Ellicium.openTooltip",
                tooltip.Element,
                UniqueID,
                tooltip.Options.Delay,
                tooltip.Options.Duration,
                Enum.GetName(typeof(TooltipPosition), tooltip.Options.Position).ToLowerInvariant(),
                tooltip.Options.CloseTooltipOnDocumentClick);
        }
    }

    bool IsJSRuntimeAvailable { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        IsJSRuntimeAvailable = true;

        var tooltip = tooltips.LastOrDefault();

        if (tooltip != null)
        {
            await JSRuntime.InvokeVoidAsync("Ellicium.openTooltip",
                tooltip.Element,
                UniqueID,
                tooltip.Options.Delay,
                tooltip.Options.Duration,
                Enum.GetName(typeof(TooltipPosition), tooltip.Options.Position).ToLowerInvariant(),
                tooltip.Options.CloseTooltipOnDocumentClick,
                Reference,
                "ElliciumTooltip.CloseTooltip");
        }
    }

    private DotNetObjectReference<ElliciumTooltip> reference;

    /// <summary>
    /// Gets the reference for the current component.
    /// </summary>
    /// <value>The reference.</value>
    protected DotNetObjectReference<ElliciumTooltip> Reference
    {
        get
        {
            if (reference == null)
            {
                reference = DotNetObjectReference.Create(this);
            }

            return reference;
        }
    }

    /// <summary>
    /// Closes this instance.
    /// </summary>
    [JSInvokable("ElliciumTooltip.CloseTooltip")]
    public void CloseTooltip()
    {
        Service.Close();
    }

    public async Task Close()
    {
        var lastTooltip = tooltips.LastOrDefault();
        if (lastTooltip != null)
        {
            if (IsJSRuntimeAvailable)
            {
                try
                {
                    tooltips.Remove(lastTooltip);
                    await JSRuntime.InvokeVoidAsync("Ellicium.closeTooltip", UniqueID);   
                }
                catch
                {
                    // ignored
                }
            }
            
        }

        await InvokeAsync(() => { StateHasChanged(); });
    }

    public async ValueTask DisposeAsync()
    {
        while (tooltips.Count != 0)
        {
            await Close();
        }
        reference?.Dispose();
        reference = null;

        if (IsJSRuntimeAvailable)
        {
            try
            {
               await JSRuntime.InvokeVoidAsync("Ellicium.destroyPopup", UniqueID);
            }
            catch
            {
                // ignored
            }
        }

        Service.OnOpen -= OnOpen;
        Service.OnClose -= OnClose;
        Service.OnNavigate -= OnNavigate;
    }

    protected override void OnInitialized()
    {
        UniqueID = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("/", "-").Replace("+", "-").Substring(0, 10);

        Service.OnOpen += OnOpen;
        Service.OnClose += OnClose;
        Service.OnNavigate += OnNavigate;
    }

    void OnOpen(ElementReference element, Type type, TooltipOptions options)
    {
        Open(element, type, options).ConfigureAwait(false);
    }

    void OnClose()
    {
        Close().ConfigureAwait(false);
    }

    void OnNavigate()
    {
        JSRuntime.InvokeVoidAsync("Ellicium.closePopup", UniqueID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
