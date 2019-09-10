using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Inventory.Model;

namespace leltar.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
         private readonly InventoryDbContext _context;

        public InventoryController(InventoryDbContext context)
        {
            _context = context;
        }
        // GET: api/Todo/5
        [HttpGet("{Vonalkod}")]
        public async Task<ActionResult<InventoryData>> GetInventoryData(string Vonalkod)
        {
            var inventoryItem = await _context.InventoryDatas.SingleOrDefaultAsync(predicate: m => m.Vonalkod == Vonalkod);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }
    }
}