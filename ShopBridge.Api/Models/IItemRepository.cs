using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Api.Models
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItem(int id);
        Task<Item> AddItem(Item item);
        Task<Item> UpdateItem(Item item);
        Task<Item> DelteItem(int itemId);
    }
}
