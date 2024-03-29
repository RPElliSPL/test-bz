using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace Ellicium.Blazor
{
    /// <summary>
    /// ElliciumGravatar component.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;ElliciumGravatar Email="info@Ellicium.com" /&gt;
    /// </code>
    /// </example>
    public partial class ElliciumGravatar : ElliciumComponent
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [Parameter]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        [Parameter]
        public string AlternateText { get; set; } = "gravatar";

        /// <summary>
        /// Gets gravatar URL.
        /// </summary>
        protected string Url
        {
            get
            {
                var md5Email = MD5.Calculate(System.Text.Encoding.ASCII.GetBytes(Email != null ? Email : ""));

                var style = "retro";
                var width = "36";

                return $"https://secure.gravatar.com/avatar/{md5Email}?d={style}&s={width}";
            }
        }

        string GetAlternateText()
        {
            if (Attributes != null && Attributes.TryGetValue("alt", out var @alt) && !string.IsNullOrEmpty(Convert.ToString(@alt)))
            {
                return $"{AlternateText} {@alt}";
            }

            return AlternateText;
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return "rz-gravatar";
        }
    }
}
