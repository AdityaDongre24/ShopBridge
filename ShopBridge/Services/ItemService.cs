using Microsoft.AspNetCore.Components;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient httpClient;

        public ItemService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            return await httpClient.GetJsonAsync<Item[]>("api/Items");
        }

        public async Task<Item> GetItem(int id)
        {
            return await httpClient.GetJsonAsync<Item>($"api/Items/{id}");
        }

        public async Task DeleteItem(int id)
        {
             await httpClient.DeleteAsync($"api/Items/{id}");
        }

        public async Task<Item> AddItem(Item item)
        {
            return await httpClient.PostJsonAsync<Item>($"api/Items", item);
        }

        public async Task<Item> UpdateItem(int id, Item item)
        {
            return await httpClient.PutJsonAsync<Item>($"api/Items/{id}", item);
        }
    }
}
