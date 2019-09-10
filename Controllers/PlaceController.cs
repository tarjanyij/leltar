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
    public class PlaceController : ControllerBase
    {
         private readonly InventoryDbContext _context;

        public PlaceController(InventoryDbContext context)
        {
            _context = context;
        }
       

        [HttpGet("{LeltarKorzet}")]
        public async Task<List<InventoryData>> GetPlaceData(string LeltarKorzet)
        {
             
             var inventoryItem = await _context.InventoryDatas.Where(m=>m.LeltarKorzet == LeltarKorzet).ToListAsync();
            if (inventoryItem == null)
            {
                return null;
            }

            return inventoryItem;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class NamePlaceController : ControllerBase
    {
         private readonly InventoryDbContext _context;

        public NamePlaceController(InventoryDbContext context)
        {
            _context = context;
        }
       

        [HttpGet()]
        public async Task<InventoryData> GetPlaceData()
        {
             
             var inventoryItem = _context.InventoryDatas.Select(m=>m.LeltarKorzetMegnevezes);
            

            return  inventoryItem.Distinct();
        }
    }
}