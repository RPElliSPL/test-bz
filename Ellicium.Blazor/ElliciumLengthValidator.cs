﻿using Microsoft.AspNetCore.Components;

namespace Ellicium.Blazor
{
    /// <summary>
    /// A validator component which checks if then component value length is within a specified range.
    /// Must be placed inside a <see cref="ElliciumTemplateForm{TItem}" />
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumTemplateForm TItem="Model" Data=@model&gt;
    ///    &lt;ElliciumTextBox style="display: block" Name="FirstName" @bind-Value=@model.FirstName /&gt;
    ///    &lt;ElliciumLengthValidator Component="FirstName" Min="3" Text="First name should be at least 3 characters" Style="position: absolute" /&gt;
    /// &lt;/ElliciumTemplateForm&gt;
    /// @code {
    ///    class Model
    ///    {
    ///       public string FirstName { get; set; }
    ///    }
    ///    Model model = new Model(); 
    /// }
    /// </code>
    /// </example>
    public class ElliciumLengthValidator : ValidatorBase
    {
        /// <summary>
        /// Gets or sets the message displayed when the component is invalid. Set to <c>"Invalid length"</c> by default.
        /// </summary>
        [Parameter]
        public override string Text { get; set; } = "Invalid length";

        /// <summary>
        /// Specifies the minimum accepted length. The component value length should be greater than the minimum in order to be valid.
        /// </summary>
        [Parameter]
        public int? Min { get; set; }

        /// <summary>
        /// Specifies the maximum accepted length. The component value length should be less than the maximum in order to be valid.
        /// </summary>
        [Parameter]
        public int? Max { get; set; }

        /// <inheritdoc />
        protected override bool Validate(IElliciumFormComponent component)
        {
            string value = component.GetValue() as string;

            if (Min.HasValue && ((value != null && value.Length < Min) || value == null))
            {
                return false;
            }

            if (Max.HasValue && (value != null && value.Length > Max))
            {
                return false;
            }

            return true;
        }
    }
}