using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebInventoryManagementSystem_IT703_2016012187.Models;

namespace WebInventoryManagementSystem_IT703_2016012187.Data
{
    public class WebInventoryManagementSystem_IT703_2016012187Context : DbContext
    {
        public WebInventoryManagementSystem_IT703_2016012187Context (DbContextOptions<WebInventoryManagementSystem_IT703_2016012187Context> options)
            : base(options)
        {
        }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Brand> Brand { get; set; } = default!;

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Category> Category { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Client> Client { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Supplier> Supplier { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Location> Location { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Inventory> Inventory { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.Product> Product { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.IncomingOrder> IncomingOrder { get; set; }

        public DbSet<WebInventoryManagementSystem_IT703_2016012187.Models.OutgoingOrder> OutgoingOrder { get; set; }
    }
}
