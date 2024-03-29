using Bunit;
using Xunit;

namespace Ellicium.Blazor.Tests
{
    public class ColorPickerTests
    {
        [Fact]
        public void ColorPicker_ShouldAcceptInvalidValues()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<ElliciumColorPicker>(ComponentParameter.CreateParameter("Value", "invalid"));
        }
    }
}
