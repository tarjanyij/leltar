using Inventory.Model; //kell a model névtér
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data

{
    public class InventoryDbContext : DbContext 
    {
        public InventoryDbContext( DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<InventoryData> InventoryDatas { get; set; }// kapcsolat az SQL táblával a modell alapján
    }
}