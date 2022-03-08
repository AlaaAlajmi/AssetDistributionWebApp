using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetDistributionWebApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            
        }
       public DbSet<assets> assets { get; set; }
       public DbSet<distribution> distributions { get; set; }

    }
}
