// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ellicium.Blazor
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Rishabh\Blazor-test-bz\test-bz\Ellicium.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rishabh_Patil\source\repos\Rishabh\Blazor-test-bz\test-bz\Ellicium.Blazor\ElliciumNotificationMessage.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class ElliciumNotificationMessage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Rishabh_Patil\source\repos\Rishabh\Blazor-test-bz\test-bz\Ellicium.Blazor\ElliciumNotificationMessage.razor"
       
   Tuple<string, string> GetMessageCssClasses()
   {
      if (Message.Severity == NotificationSeverity.Error)
      {
         return new Tuple<string, string>("rz-growl-message-error", "rzi-times");
      }
      else if (Message.Severity == NotificationSeverity.Info)
      {
         return new Tuple<string, string>("rz-growl-message-info", "rzi-info-circle");
      }
      else if (Message.Severity == NotificationSeverity.Success)
      {
         return new Tuple<string, string>("rz-growl-message-success", "rzi-check");
      }
      else if (Message.Severity == NotificationSeverity.Warning)
      {
         return new Tuple<string, string>("rz-growl-message-warn", "rzi-exclamation-triangle");
      }

      return new Tuple<string, string>("", "");
   }

   [Inject] private NotificationService Service { get; set; }

   public bool Visible { get; set; } = true;

   [Parameter]
   public NotificationMessage Message { get; set; }

   [Parameter]
   public string Style { get; set; }

   public void Close()
   {
      Service.Messages.Remove(Message);
      Message?.Close?.Invoke(Message);
      //System.Threading.Tasks.Task.Delay(0).ContinueWith(r => { Visible = false; });
   }

   protected override void OnInitialized()
   {
      System.Threading.Tasks.Task.Delay(Convert.ToInt32(Message.Duration ?? 3000)).ContinueWith(r => InvokeAsync(Close));
   }

   private void NotificationClicked()
   {
      if (Message.CloseOnClick)
         Close();

      Message?.Click?.Invoke(Message);
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
