#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a08d2d404b28ba5db4b990f5041d9c926bfb1b6e856ec464c068e60e71de79a8"
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
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
    public partial class ElliciumNotification : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-notification");
            __builder.AddAttribute(2, "style", "position:fixed;z-index:1002;top:100px;float:right;right:10px;" + (
#nullable restore
#line 4 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
                                                                                                  Style

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
 for (var i = 0; i < Service.Messages.Count; i++)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.SetKey(
#nullable restore
#line 7 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
               Service.Messages[i]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\n        ");
#nullable restore
#line (8,10)-(8,45) 24 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
__builder.AddContent(7, DrawMessage(i, Service.Messages[i]));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 10 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\ElliciumNotification.razor"
       
    [Inject] private NotificationService Service { get; set; }

    [Parameter]
    public string Style { get; set; }

    RenderFragment DrawMessage(int index, NotificationMessage m)
    {
        return new RenderFragment(builder =>
        {
            var i = 0;
            builder.OpenComponent(i, typeof(ElliciumNotificationMessage));
            builder.AddAttribute(i++, "Message", m);
            builder.AddAttribute(i++, "Style", m.Style);
            builder.CloseComponent();
        });
    }

    void Update(object sender, NotifyCollectionChangedEventArgs args)
    {
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        Service.Messages.CollectionChanged -= Update;
    }

    protected override void OnInitialized()
    {
        Service.Messages.CollectionChanged += Update;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
