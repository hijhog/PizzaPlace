using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Pages
{
   public class InputWatcher : ComponentBase
   {
      private EditContext editContext;
      [CascadingParameter]
      public EditContext EditContext 
      {
         get => editContext;
         set
         {
            this.editContext = value;
            EditContext.OnFieldChanged += async (sender, e)
               =>
            {
               await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
            };
         } 
      }

      [Parameter]
      public EventCallback<string> FieldChanged { get; set; }

      public bool Validate()
         => EditContext?.Validate() ?? false;
   }
}
