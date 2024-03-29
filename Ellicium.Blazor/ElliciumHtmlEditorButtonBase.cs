using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Ellicium.Blazor
{
    /// <summary>
    /// Base class that ElliciumHtmlEditor color picker tools inherit from.
    /// </summary>
    public abstract class ElliciumHtmlEditorButtonBase : ComponentBase, IDisposable
    {
        /// <summary>
        /// The ElliciumHtmlEditor component which this tool is part of.
        /// </summary>
        [CascadingParameter]
        public ElliciumHtmlEditor Editor { get; set; }

        /// <summary>
        /// Specifies the name of the command. It is available as <see cref="HtmlEditorExecuteEventArgs.CommandName" /> when
        /// <see cref="ElliciumHtmlEditor.Execute" /> is raised.
        /// </summary>
        protected virtual string CommandName { get; }

        /// <summary>
        /// Specifies the shortcut for the command. Can be in the form of <c>"Ctrl+X"</c> or <c>"Alt+Shift+Z"</c>.
        /// </summary>
        [Parameter]
        public virtual string Shortcut { get; set; }

        /// <summary>
        /// Handles the click event of the button. Executes the command.
        /// </summary>
        protected virtual async Task OnClick()
        {
            await Editor.ExecuteCommandAsync(CommandName);
        }

        /// <inheritdoc />
        protected override void OnInitialized()
        {
            if (!string.IsNullOrEmpty(Shortcut))
            {
                Editor?.RegisterShortcut(Shortcut, OnClick);
            }
        }

        /// <summary>
        /// IDisposable implementation.
        /// </summary>
        public void Dispose()
        {
            if (!string.IsNullOrEmpty(Shortcut))
            {
                Editor?.UnregisterShortcut(Shortcut);
            }
        }
    }
}
