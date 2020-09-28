using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItems();

        Task<Item> GetItem(int id);

        Task DeleteItem(int id);

        Task<Item> AddItem(Item item);

        Task<Item> UpdateItem(int id, Item item);
    }
}
