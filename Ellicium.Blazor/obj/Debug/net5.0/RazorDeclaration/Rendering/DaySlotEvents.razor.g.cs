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
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\DaySlotEvents.razor"
using Ellicium.Blazor;

#line default
#line hidden
#nullable disable
    public partial class DaySlotEvents : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Ellicium.Blazor\Rendering\DaySlotEvents.razor"
       
    [Parameter]
    public int CurrentAppointment { get; set; } = -1;

    [Parameter]
    public DateTime CurrentDate { get; set; }

    [CascadingParameter]
    public IScheduler Scheduler { get; set; }

    [Parameter]
    public DateTime StartDate { get; set; }

    [Parameter]
    public DateTime EndDate { get; set; }

    [Parameter]
    public int MinutesPerSlot { get; set; }

    [Parameter]
    public EventCallback<AppointmentData> AppointmentDragStart { get; set; }

    [Parameter]
    public IList<AppointmentData> Appointments { get; set; }

    async Task OnAppointmentSelect(AppointmentData data)
    {
        await Scheduler.SelectAppointment(data);
    }

    private AppointmentData[] AppointmentsInSlot(DateTime start, DateTime end)
    {
        if (Appointments == null)
        {
            return Array.Empty<AppointmentData>();
        }

        return Appointments.Where(item => Scheduler.IsAppointmentInRange(item, start, end)).OrderBy(item => item.Start).ThenByDescending(item => item.End).ToArray();
    }

    double DetermineLeft(HashSet<double> existingLefts, double width)
    {
        double left = 0;

        while (existingLefts.Contains(left))
        {
            left += width;
        }

        return left;
    }

    HashSet<double> ExistingLefts(IDictionary<AppointmentData, double> lefts, IEnumerable<AppointmentData> appointments)
    {
        var existingLefts = new HashSet<double>();

        foreach (var appointment in appointments)
        {
            if (lefts.TryGetValue(appointment, out var existingLeft))
            {
                existingLefts.Add(existingLeft);
            }
        }

        return existingLefts;
    }
    private IDictionary<int, int> AppointmentGroups()
    {
        var groups = new Dictionary<int, int>();

        for (var index = 0; index < Appointments.Count(); index++)
        {
            groups[index] = 0;
        }

        for (var date = StartDate; date < EndDate; date = date.AddMinutes(MinutesPerSlot))
        {
            var start = date;
            var end = start.AddMinutes(MinutesPerSlot);

            var appointments = AppointmentsInSlot(start, end);

            foreach (var item in appointments)
            {
                var index = Appointments.IndexOf(item);

                var count = groups[index];

                groups[index] = Math.Max(appointments.Length, count);
            }
        }

        return groups;
    }

    public async Task OnAppointmentDragStart(AppointmentData Data)
    {
        await AppointmentDragStart.InvokeAsync(Data);
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
