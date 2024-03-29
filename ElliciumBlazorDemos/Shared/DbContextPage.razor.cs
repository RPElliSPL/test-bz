using ElliciumBlazorDemos.Data;
using ElliciumBlazorDemos.Models.Northwind;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ElliciumBlazorDemos.Shared
{
    public partial class DbContextPage : ComponentBase
    {
        [Inject]
        public IDbContextFactory<NorthwindContext> DbFactory { get; set; }

        protected NorthwindContext dbContext;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            if (dbContext == null)
            {
                dbContext = await DbFactory.CreateDbContextAsync();
                await dbContext.SeedAsync();
            }
        }
    }
}