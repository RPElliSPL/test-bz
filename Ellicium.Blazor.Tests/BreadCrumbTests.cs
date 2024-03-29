using Bunit;
using Xunit;

namespace Ellicium.Blazor.Tests
{
    public class BreadCrumbTests
    {
        [Fact]
        public void BreadCrumb_Renders_Items()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBreadCrumb>();

            component.SetParametersAndRender(parameters =>
            {
                parameters.Add(c => c.ChildContent, builder =>
          {
              builder.OpenComponent<ElliciumBreadCrumbItem>(0);
              builder.AddAttribute(1, nameof(ElliciumBreadCrumbItem.Text), "Test");
              builder.CloseComponent();
          });
            });
            //@"<ElliciumBreadCrumbItem Text=""Test"" />"
            Assert.Contains(@"class=""rz-breadcrumb-item", component.Markup);
            Assert.Contains(">Test</", component.Markup);
        }

        [Fact]
        public void BreadCrumb_Renders_Icon()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBreadCrumb>();

            component.SetParametersAndRender(parameters =>
            {
                parameters.Add(c => c.ChildContent, builder =>
          {
              builder.OpenComponent<ElliciumBreadCrumbItem>(0);
              builder.AddAttribute(1, nameof(ElliciumBreadCrumbItem.Text), "Test");
              builder.AddAttribute(2, nameof(ElliciumBreadCrumbItem.Icon), "add");
              builder.CloseComponent();
          });
            });

            //@"<ElliciumBreadCrumbItem Text=""Test"" />"
            Assert.Contains("<i", component.Markup);
            Assert.Contains(">add</i>", component.Markup);
        }

        [Fact]
        public void BreadCrumb_Renders_Link()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBreadCrumb>();

            component.SetParametersAndRender(parameters =>
            {
                parameters.Add(c => c.ChildContent, builder =>
                {
                    builder.OpenComponent<ElliciumBreadCrumbItem>(0);
                    builder.AddAttribute(1, nameof(ElliciumBreadCrumbItem.Text), "Test");
                    builder.AddAttribute(2, nameof(ElliciumBreadCrumbItem.Icon), "add");
                    builder.AddAttribute(3, nameof(ElliciumBreadCrumbItem.Path), "/badge");
                    builder.CloseComponent();
                });
            });

            //@"<ElliciumBreadCrumbItem Text=""Test"" />"
            Assert.Contains("<i", component.Markup);
            Assert.Contains(">add</i>", component.Markup);
            Assert.Contains("<a href=\"/badge", component.Markup);
        }
    }
}
