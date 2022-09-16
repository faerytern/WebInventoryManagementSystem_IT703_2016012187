using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
