using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Shared
{
    public class AlertModalBase : ComponentBase
    {
        public bool ShowAlert { get; set; } = false;

        [Parameter]
        public string ModalHeader { get; set; } = "Alert";
        [Parameter]
        public string ModalBody { get; set; } = "Operation Performed Successfully";
        [Parameter]
        public string ModalButtonText { get; set; } = "OK";
        [Parameter]
        public EventCallback OnAlertClicked { get; set; }

        public void Show()
        {
            ShowAlert = true;
            StateHasChanged();
        }

        protected async Task CloseAlert()
        {
            ShowAlert = false;
            await OnAlertClicked.InvokeAsync(null);
        }
    }
}
