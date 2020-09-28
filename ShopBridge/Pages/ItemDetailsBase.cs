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
    public class ItemDetailsBase : ComponentBase
    {
        public Item Item { get; set; }
        public List<string> LocalImages { get; set; } = new List<string>();
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IItemService ItemService { get; set; }

        [Inject]
        private NavigationManager navigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Item = await ItemService.GetItem(int.Parse(Id));
            //Add Local Images to Drop Down
            DirectoryInfo directoryInfo = new DirectoryInfo("wwwroot/Images");
            if (directoryInfo.Exists)
            {
                FileInfo[] files = directoryInfo.GetFiles("*.png");
                foreach (FileInfo file in files)
                {
                    LocalImages.Add("images/" + file.Name);
                }
            }
        }

        #region AlertModel

        protected AlertModal AlertModal { get; set; }
        [Parameter]
        public string AlertModalHeader { get; set; }
        [Parameter]
        public string AlertModalBody { get; set; }
        [Parameter]
        public string AlertModalButtonText { get; set; }

        protected async Task HandleValidSubmit()
        {
            var result = await ItemService.UpdateItem(int.Parse(Id), Item);
            if (result != null)
            {
                AlertModalHeader = "Updated";
                AlertModalBody = "Update operation completed successfully";
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
            navigationManager.NavigateTo("/");
        }

        #endregion

    }
}
