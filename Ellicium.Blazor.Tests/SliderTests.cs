using Bunit;
using Ellicium.Blazor.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Ellicium.Blazor.Tests
{
    public class SliderTests
    {
        [Fact]
        public void Slider_Renders_CssClass()
        {
            using var ctx = new TestContext();
            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.JSInterop.SetupModule("_content/Ellicium.Blazor/Ellicium.Blazor.js");

            var component = ctx.RenderComponent<ElliciumSlider<int>>();

            Assert.Contains(@$"rz-slider", component.Markup);
            Assert.Contains(@$"rz-slider-horizontal", component.Markup);
            Assert.Contains(@$"rz-slider-handle", component.Markup);
            Assert.Contains(@$"rz-slider-range rz-slider-range-min", component.Markup);
        }

        [Fact]
        public void Slider_Renders_ValueParameter()
        {
            using var ctx = new TestContext();
            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.JSInterop.SetupModule("_content/Ellicium.Blazor/Ellicium.Blazor.js");

            var component = ctx.RenderComponent<ElliciumSlider<int>>();

            decimal max = 100;
            var value = 4;

            component.SetParametersAndRender(parameters => parameters.Add<int>(p => p.Value, value));

            Assert.Contains(@$"style=""width: {Math.Round((value / max * 100)).ToInvariantString()}%;""", component.Markup);
            Assert.Contains(@$"style=""left: {Math.Round((value / max * 100)).ToInvariantString()}%;""", component.Markup);
        }

        [Fact]
        public void Slider_Renders_ValueParameterWithRange()
        {
            using var ctx = new TestContext();
            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.JSInterop.SetupModule("_content/Ellicium.Blazor/Ellicium.Blazor.js");

            var component = ctx.RenderComponent<ElliciumSlider<IEnumerable<int>>>(parameterBuilder => parameterBuilder.Add<bool>(p => p.Range, true));

            component.SetParametersAndRender(parameters => {
                parameters.Add<IEnumerable<int>>(p => p.Value, new int[] { 4, 30 });
            });

            Assert.Contains(@$"left: 4%", component.Markup);
            Assert.Contains(@$"left: 30%", component.Markup);
            Assert.Contains(@$"left: 4%; width: 26%;", component.Markup);
        }

        [Fact]
        public void Slider_Renders_StyleParameter()
        {
            using var ctx = new TestContext();
            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.JSInterop.SetupModule("_content/Ellicium.Blazor/Ellicium.Blazor.js");

            var component = ctx.RenderComponent<ElliciumSlider<int>>();

            var value = "width:20px";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Style, value));

            Assert.Contains(@$"style=""{value}""", component.Markup);
        }

        [Fact]
        public void Slider_Renders_UnmatchedParameter()
        {
            using var ctx = new TestContext();
            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.JSInterop.SetupModule("_content/Ellicium.Blazor/Ellicium.Blazor.js");

            var component = ctx.RenderComponent<ElliciumSlider<int>>();

            component.SetParametersAndRender(parameters => parameters.AddUnmatched("autofocus", ""));

            Assert.Contains(@$"autofocus", component.Markup);
        }
    }
}
