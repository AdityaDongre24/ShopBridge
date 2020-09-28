using Microsoft.AspNetCore.Components;
using ShopBridge.Services;
using ShopBridge.Shared;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public class DisplayItemBase : ComponentBase
    {
        [Parameter]
        public Item Item { get; set; }

        protected ConfirmModal DeleteConfirmation { get; set; }

        [Parameter]
        public EventCallback<int> OnItemDeleted { get; set; }

        [Inject]
        public IItemService ItemService { get; set; }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task Confirmation_DeleteClick(bool deleteConfirmation)
        {
            if (deleteConfirmation)
            {
                await ItemService.DeleteItem(Item.Id);
                await OnItemDeleted.InvokeAsync(Item.Id);
            }

        }
    }
}
