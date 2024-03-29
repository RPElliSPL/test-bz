using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A validator component which checks if a component has value.
    /// Must be placed inside a <see cref="ElliciumTemplateForm{TItem}" />
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumTemplateForm TItem="Model" Data=@model&gt;
    ///   &lt;ElliciumTextBox style="display: block" Name="Email" @bind-Value=@model.Email /&gt;
    ///   &lt;ElliciumRequiredValidator Component="Email" Text="Email is required" Style="position: absolute" /&gt;
    /// &lt;/ElliciumTemplateForm&gt;
    /// @code {
    ///  class Model
    ///  {
    ///    public string Email { get; set; }
    ///  }
    ///  
    ///  Model model = new Model();
    /// }
    /// </code>
    /// </example>
    public class ElliciumRequiredValidator : ValidatorBase
    {
        /// <summary>
        /// Gets or sets the message displayed when the component is invalid. Set to <c>"Required"</c> by default.
        /// </summary>
        [Parameter]
        public override string Text { get; set; } = "Required";

        /// <inheritdoc />
        protected override bool Validate(IElliciumFormComponent component)
        {
            return component.HasValue && !object.Equals(DefaultValue, component.GetValue());
        }

        /// <summary>
        /// Specifies a default value. If the component value is equal to <c>DefaultValue</c> it is considered invalid.
        /// </summary>
        [Parameter]
        public object DefaultValue { get; set; }
    }
}