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
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridFilterMenu.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridFilterMenu.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class RadzenDataGridFilterMenu<
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridFilterMenu.razor"
TItem

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridFilterMenu.razor"
       
    [Parameter]
    public ElliciumDataGridColumn<TItem> Column { get; set; }

    [Parameter]
    public ElliciumDataGrid<TItem> Grid { get; set; }

    protected string FilterOperatorStyle(ElliciumDataGridColumn<TItem> column, FilterOperator value)
    {
        return column.GetFilterOperator() == value ?
            "elli-multiselect-item elli-state-highlight" :
            "elli-multiselect-item";
    }

    protected string FilterIconStyle()
    {
        var additionalStyle = Column.HasActiveFilter() ? "elli-grid-filter-active" : "";

        return $"elli-filter-button elli-button elli-button-md elli-button-icon-only elli-variant-flat elli-light {additionalStyle}";
    }

    protected async Task ApplyFilter(FilterOperator value)
    {
        if (value == FilterOperator.IsNull || value == FilterOperator.IsNotNull 
            || value == FilterOperator.IsEmpty || value == FilterOperator.IsNotEmpty)
        {
            Column.SetFilterValue(value == FilterOperator.IsEmpty || value == FilterOperator.IsNotEmpty ? string.Empty : null);
            Column.SetFilterValue(null, false);
        }

        Column.SetFilterOperator(value);

        Grid.SaveSettings();

        await Grid.Filter.InvokeAsync(new DataGridColumnFilterEventArgs<TItem>()
        {
            Column = Column,
            FilterValue = Column.GetFilterValue(),
            SecondFilterValue = Column.GetSecondFilterValue(),
            FilterOperator = Column.GetFilterOperator(),
            SecondFilterOperator = Column.GetSecondFilterOperator(),
            LogicalFilterOperator = Column.GetLogicalFilterOperator()
        });

        await JSRuntime.InvokeVoidAsync("Ellicium.closePopup", $"{Grid.PopupID}{Column.GetFilterProperty()}");
        await Grid.ReloadInternal();
    }

    protected async Task ClearFilter()
    {
        Column.ClearFilters();

        Grid.SaveSettings();

        await JSRuntime.InvokeVoidAsync("Ellicium.closePopup", $"{Grid.PopupID}{Column.GetFilterProperty()}");

        await Grid.FilterCleared.InvokeAsync(new DataGridColumnFilterEventArgs<TItem>()
        {
            Column = Column,
            FilterValue = Column.GetFilterValue(),
            SecondFilterValue = Column.GetSecondFilterValue(),
            FilterOperator = Column.GetFilterOperator(),
            SecondFilterOperator = Column.GetSecondFilterOperator(),
            LogicalFilterOperator = Column.GetLogicalFilterOperator()
        });

        await Grid.ReloadInternal();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
