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
#line 2 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#nullable disable
    public partial class RadzenDataGridGroupFooterRow<
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
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
#line 31 "C:\Users\Rishabh_Patil\source\repos\Blazor\Ellicium Packages\ellicium-blazor-master\ellicium-blazor-master\Radzen.Blazor\RadzenDataGridGroupFooterRow.razor"
       
        [Parameter]
        public IList<ElliciumDataGridColumn<TItem>> Columns { get; set; }

        GroupResult _groupResult;
        [Parameter]
        public GroupResult GroupResult 
        { 
            get
            {
                return _groupResult;
            }
            set
            {
                if(_groupResult != value)
                {
                    _groupResult = value;

                    var l = GetLevel();
                    var level = l > 0 ? l - 1 : l;

                    Group = new Group()
                    {
                        Level = level,
                        GroupDescriptor = Grid.Groups[level],
                        Data = _groupResult
                    };
                }
            }
        }

        [Parameter]
        public ElliciumDataGrid<TItem> Grid { get; set; }

        [Parameter]
        public ElliciumDataGridGroupRow<TItem> Parent { get; set; }

        [Parameter]
        public Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder Builder { get; set; }

        public Group Group { get; set; }

        int GetLevel()
        {
            int i = 0;
            var p = Parent;
            while(p != null)
            {
                p = p.Parent;
                i++;
            }

            return i;
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
