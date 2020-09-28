using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Api.Models;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetItems()
        {
            try
            {
                return Ok(await itemRepository.GetItems());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in loading Item data");
            }
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Item>> GetItem(int Id)
        {
            try
            {
                var result = await itemRepository.GetItem(Id);
                if (result == null)
                    return NotFound();
                else
                    return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in loading Item data");
            }

        }

        [HttpPost]
        public async Task<ActionResult<Item>> CreateItem(Item item)
        {
            try
            {
                if(item == null)
                {
                    return BadRequest();
                }
                var createdItem = await itemRepository.AddItem(item);

                return CreatedAtAction(nameof(GetItem), new { Id = createdItem.Id }, createdItem);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Create Item data");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Item>> UpdateItem(int id, Item item)
        {
            try
            {
                if(id != item.Id)
                    return BadRequest("Item Id mismatch");

                var existingItem = await itemRepository.GetItem(id);

                if (existingItem == null)
                    return NotFound($"Item with id = {id} not found");

                return await itemRepository.UpdateItem(item);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Updating Item data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Item>> DeleteItem(int id)
        {
            try
            {
                var deleteItem = await itemRepository.GetItem(id);
                if(deleteItem == null)
                {
                    return NotFound($"Item with id = {id} not found");
                }

                return await itemRepository.DelteItem(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Deleting Item data");
            }
        }
    }
}
