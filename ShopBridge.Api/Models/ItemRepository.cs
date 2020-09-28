using Microsoft.EntityFrameworkCore;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Api.Models
{
    public class ItemRepository : IItemRepository
    {

        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Item> AddItem(Item item)
        {
            var result = await appDbContext.Items.AddAsync(item);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Item> DelteItem(int itemId)
        {
            var result = await appDbContext.Items.FirstOrDefaultAsync(i => i.Id == itemId);
            if(result != null)
            {
                appDbContext.Items.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Item> GetItem(int id)
        {
            return await appDbContext.Items.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            return await appDbContext.Items.ToListAsync();
        }

        public async Task<Item> UpdateItem(Item item)
        {
            var result = await appDbContext.Items.FirstOrDefaultAsync(i => i.Id == item.Id);
            if(result != null)
            {
                result.Name = item.Name;
                result.Description = item.Description;
                result.Price = item.Price;
                result.ImageSource = item.ImageSource;

                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}
