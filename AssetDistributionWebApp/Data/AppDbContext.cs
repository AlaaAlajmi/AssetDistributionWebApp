using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AssetDistributionWebApp.Data
{
    public class AppDbContext : IdentityDbContext<applicationusers>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<assets> assets { get; set; }
        public DbSet<distribution> distributions { get; set; }
        public DbSet<Account> accounts { get; set; }
    }
}
