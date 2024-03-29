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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Appointment.razor"
using Ellicium.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Appointment.razor"
using Ellicium.Blazor.Rendering;

#line default
#line hidden
#nullable disable
    public partial class Appointment : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\Appointment.razor"
       
    private ElementReference element;

    private string Title => Scheduler.HasMouseEnterAppointmentDelegate() ? null : Data?.Text;

    private string DraggableAttribute => Scheduler?.HasAppointmentMoveDelegate() == true ? "true" : null;

    private string OnDragStartAttribute => Scheduler?.HasAppointmentMoveDelegate() == true ? "event.dataTransfer.setData('', event.target.id)" : null;

    [Parameter]
    public string CssClass { get; set; }

    [Parameter]
    public double? Top { get; set; }

    [Parameter]
    public double? Left { get; set; }

    [Parameter]
    public double? Width { get; set; }

    [Parameter]
    public double? Height { get; set; }

    [Parameter]
    public EventCallback<AppointmentData> Click { get; set; }

    [Parameter]
    public EventCallback<AppointmentData> DragStart { get; set; }

    IDictionary<string, object> Attributes { get; set; }

    [Parameter]
    public AppointmentData Data { get; set; }

    [Parameter]
    public bool ShowAppointmentContent { get; set; } = true;

    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    string Style { get; set; }

    protected override void OnParametersSet()
    {
        Attributes = Scheduler.GetAppointmentAttributes(Data);

        var style = new List<string>();

        if (Top.HasValue)
        {
            style.Add($"top: {Top.ToInvariantString()}em");
        }

        if (Left.HasValue)
        {
            style.Add($"left: {Left.ToInvariantString()}%");
        }

        if (Width.HasValue)
        {
            style.Add($"width: {Width.ToInvariantString()}%");
        }

        if (Height.HasValue)
        {
            style.Add($"height: {Height.ToInvariantString()}em");
        }

        Style = String.Join(";", style);
    }

    async Task OnClick()
    {
        await Click.InvokeAsync(Data);
    }

    async Task OnMouseEnter()
    {
        await Scheduler.MouseEnterAppointment(element, Data);
    }

    async Task OnMouseLeave()
    {
        await Scheduler.MouseLeaveAppointment(element, Data);
    }

    public async Task OnDragStart(DragEventArgs args)
    {
        await DragStart.InvokeAsync(Data);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
