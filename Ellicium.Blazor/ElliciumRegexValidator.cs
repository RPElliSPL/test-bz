using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A validator component which matches a component value against a specified regular expression pattern.
    /// Must be placed inside a <see cref="ElliciumTemplateForm{TItem}" />
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumTemplateForm TItem="Model" Data=@model&gt;
    ///    &lt;ElliciumTextBox style="display: block" Name="ZIP" @bind-Value=@model.Zip /&gt;
    ///    &lt;ElliciumRegexValidator Component="ZIP" Text="ZIP code must be 5 digits" Pattern="\d{5}" Style="position: absolute" /&gt;
    /// &lt;/ElliciumTemplateForm&gt;
    /// @code {
    ///    class Model
    ///    {
    ///       public string Zip { get; set; }
    ///    }
    ///    Model model = new Model(); 
    /// }
    /// </code>
    /// </example>
    public class ElliciumRegexValidator : ValidatorBase
    {
        /// <summary>
        /// Gets or sets the message displayed when the component is invalid. Set to <c>"Value should match"</c> by default.
        /// </summary>
        [Parameter]
        public override string Text { get; set; } = "Value should match";

        /// <summary>
        /// Specifies the regular expression pattern which the component value should match in order to be valid.
        /// </summary>
        [Parameter]
        public string Pattern { get; set; }

        /// <inheritdoc />
        protected override bool Validate(IElliciumFormComponent component)
        {
            return new RegularExpressionAttribute(Pattern).IsValid(component.GetValue());
        }
    }
}