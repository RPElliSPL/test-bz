using Bunit;
using Xunit;

namespace Ellicium.Blazor.Tests
{
    public class LabelTests
    {
        [Fact]
        public void Label_Renders_TextParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumLabel>();

            var value = "Test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Text, value));

            Assert.Contains(@$">{value}</label>", component.Markup);
        }

        [Fact]
        public void Label_Renders_ComponentParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumLabel>();

            var value = "test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Component, value));

            Assert.Contains(@$"for=""{value}""", component.Markup);
        }

        [Fact]
        public void Label_Renders_StyleParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumLabel>();

            var value = "width:20px";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Style, value));

            Assert.Contains(@$"style=""{value}""", component.Markup);
        }

        [Fact]
        public void Label_Renders_UnmatchedParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumLabel>();

            component.SetParametersAndRender(parameters => parameters.AddUnmatched("autofocus", ""));

            Assert.Contains(@$"autofocus", component.Markup);
        }
    }
}
