using Bunit;
using Xunit;

namespace Ellicium.Blazor.Tests
{
    public class BadgeTests
    {
        [Fact]
        public void Badge_Renders_TextParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBadge>();

            var text = "Test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Text, text));

            Assert.Contains(text, component.Markup);
        }

        [Fact]
        public void Badge_Renders_ChildContent()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBadge>();

            component.SetParametersAndRender(parameters => parameters.AddChildContent("SomeContent"));

            Assert.Contains(@$"SomeContent", component.Markup);
        }

        [Fact]
        public void Badge_Renders_BadgeStyle()
        {
            var badgeStyle = BadgeStyle.Danger;

            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumBadge>();
            component.SetParametersAndRender(parameters => parameters.Add(p => p.BadgeStyle, badgeStyle));

            Assert.Contains($"badge-{badgeStyle.ToString().ToLower()}", component.Markup);
        }
    }
}
