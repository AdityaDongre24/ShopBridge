using Microsoft.AspNetCore.Components;
using ShopBridge.Services;
using ShopBridge.Shared;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public class AddItemBase : ComponentBase
    {
        public Item Item { get; set; } = new Item();
        public List<string> LocalImages { get; set; } = new List<string>();

        [Inject]
        public IItemService ItemService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        #region AlertModal
        protected AlertModal AlertModal { get; set; }

        [Parameter]
        public string AlertModalHeader { get; set; }
        [Parameter]
        public string AlertModalBody { get; set; }
        [Parameter]
        public string AlertModalButtonText { get; set; }

        protected override Task OnInitializedAsync()
        {
            //Add Local Images to Drop Down
            DirectoryInfo directoryInfo = new DirectoryInfo("wwwroot/Images");
            if(directoryInfo.Exists)
            {
                FileInfo[] files = directoryInfo.GetFiles("*.png");
                foreach (FileInfo file in files)
                {
                    LocalImages.Add("images/" + file.Name);
                }
            }
            return base.OnInitializedAsync();
        }
        protected async Task HandleValidSubmit()
        {
            var result = await ItemService.AddItem(Item);
            if(result != null)
            {
                AlertModalHeader = "Submitted";
                AlertModalBody = "Submit operation completed successfully";
                AlertModalButtonText = "Ok";
            }
            else
            {
                AlertModalHeader = "Error";
                AlertModalBody = "Something went wrong, please try again later";
                AlertModalButtonText = "Ok";
            }

            AlertModal.Show();
        }
        public void GoToHomePage()
        {
            NavigationManager.NavigateTo("/");
        }

        #endregion

    }
}
