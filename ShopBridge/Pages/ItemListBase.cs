using Microsoft.AspNetCore.Components;
using ShopBridge.Services;
using ShopBridge.Shared;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public class ItemListBase : ComponentBase
    {
        [Inject]
        public IItemService ItemService { get; set; }

        public List<Item> ItemList { get; set; }

        public async Task ItemDeleted()
        {
            ItemList = (await ItemService.GetItems()).ToList();
        }

        protected override async Task OnInitializedAsync()
        {
            ItemList = (await ItemService.GetItems()).ToList();
        }

    }
}
