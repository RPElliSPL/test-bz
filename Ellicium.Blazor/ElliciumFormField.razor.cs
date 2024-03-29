using Ellicium.Blazor.Rendering;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Interface that represents the context of the form field.
    /// </summary>
    public interface IFormFieldContext
    {
        /// <summary>
        /// Notifies the form field that the disabled state of the component has changed.
        /// </summary>
        Action<bool> DisabledChanged { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the label is floating or fixed on top.
        /// </summary>
        bool AllowFloatingLabel { get; set; }
    }

    /// <summary>
    /// Represents the context of the form field.
    /// </summary>
    public class FormFieldContext : IFormFieldContext
    {
        /// <summary>
        /// Notifies the form field that the disabled state of the component has changed.
        /// </summary>
        public Action<bool> DisabledChanged { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the label is floating or fixed on top.
        /// </summary>
        public bool AllowFloatingLabel { get; set; }
    }

    /// <summary>
    /// A Blazor component that wraps another component and adds a label, helper text, start and end content.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumFormField Text="Search"&gt;
    ///   &lt;ElliciumTextBox @bind-Value="@text" /&gt;
    /// &lt;/ElliciumFormField&gt;
    /// </code>
    /// </example>
    public partial class ElliciumFormField : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the child content. The child content is wrapped by the form field. Can be used with ElliciumTextBox, ElliciumTextArea, ElliciumPassword, ElliciumDropDown, ElliciumDropDownList, ElliciumNumeric.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Gets or sets the optional content that will be rendered before the child content. Usually used with ElliciumIcon.
        /// </summary>
        /// <example>
        /// <code>
        /// &lt;ElliciumFormField Text="Search"&gt;
        ///   &lt;Start&gt;
        ///     &lt;ElliciumIcon Icon="search" /&gt;
        ///   &lt;/Start&gt;
        ///   &lt;ChildContent&gt;
        ///     &lt;ElliciumTextBox @bind-Value="@text" /&gt;
        ///   &lt;/ChildContent&gt;
        /// &lt;/ElliciumFormField&gt;
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment Start { get; set; }

        /// <summary>
        /// Gets or sets the optional content that will be rendered after the child content. Usually used with ElliciumIcon.
        /// </summary>
        /// <example>
        /// <code>
        /// &lt;ElliciumFormField&gt;
        ///   &lt;End&gt;
        ///     &lt;ElliciumIcon Icon="search" /&gt;
        ///   &lt;/End&gt;
        ///   &lt;ChildContent&gt;
        ///     &lt;ElliciumTextBox @bind-Value="@text" /&gt;
        ///   &lt;/ChildContent&gt;
        /// &lt;/ElliciumFormField&gt;
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment End { get; set; }

        /// <summary>
        /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
        /// </summary>
        /// <example>
        /// <code>
        /// &lt;ElliciumFormField&gt;
        ///   &lt;Helper&gt;
        ///    &lt;ElliciumRequiredValidator Component="Text" /&gt;
        ///   &lt;/Helper&gt;
        ///   &lt;ChildContent&gt;
        /// .   &lt;ElliciumTextBox @bind-Value="@text" Name="Text" /&gt;
        ///   &lt;/ChildContent&gt;
        /// &lt;/ElliciumFormField&gt;
        /// </code>
        /// </example>
        [Parameter]
        public RenderFragment Helper { get; set; }

        /// <summary>
        /// Gets or sets the label text.
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the label is floating or fixed on top.
        /// </summary>
        /// <value><c>true</c> if floating is allowed; otherwise, <c>false</c>.</value>
        [Parameter]
        public bool AllowFloatingLabel { get; set; } = true;

        /// <summary>
        /// Gets or sets the name of the form field. Used to associate the label with a component.
        /// </summary>
        [Parameter]
        public string Component { get; set; }

        /// <summary>
        /// Gets or sets the design variant of the form field.
        /// </summary>
        /// <value>The variant of the form field.</value>
        [Parameter]
        public Variant Variant { get; set; } = Variant.Outlined;

        private bool disabled;

        private readonly IFormFieldContext context;


        /// <summary>
        /// Initializes a new instance of the <see cref="ElliciumFormField"/> class.
        /// </summary>
        public ElliciumFormField()
        {
            context = new FormFieldContext { DisabledChanged = DisabledChanged, AllowFloatingLabel = AllowFloatingLabel };
        }

        private void DisabledChanged(bool value)
        {
            disabled = value;
            StateHasChanged();
        }

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            context.AllowFloatingLabel = AllowFloatingLabel;
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return ClassList.Create($"rz-form-field rz-variant-{Enum.GetName(typeof(Variant), Variant).ToLowerInvariant()}").AddDisabled(disabled).Add("rz-floating-label", AllowFloatingLabel == true).ToString();
        }
    }
}