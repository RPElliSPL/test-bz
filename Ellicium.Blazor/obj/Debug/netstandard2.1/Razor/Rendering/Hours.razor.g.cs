#pragma checksum "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b6fee546fdd3fb3c885ae329c64015fd4ba88b4000e14e20270f20a0c91ac4a3"
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
    public partial class Hours : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-slot-hours");
            __builder.AddMarkupContent(2, "\n");
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
  var minor = false; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
 for (var date = DateTime.Today.Add(Start); date < DateTime.Today.Add(End); date = date.AddMinutes(MinutesPerSlot))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
     if (minor)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "        <div class=\"rz-slot-header\"></div>\n");
#nullable restore
#line 8 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "rz-slot-header");
#nullable restore
#line (11,38)-(11,63) 24 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
__builder.AddContent(7, date.ToString(TimeFormat));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
     

    minor = !minor;
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Hours.razor"
       
    [Parameter]
    public TimeSpan Start { get; set; }

    [Parameter]
    public TimeSpan End { get; set; }

    [Parameter]
    public string TimeFormat { get; set; } = "h tt";

    [Parameter]
    public int MinutesPerSlot { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
