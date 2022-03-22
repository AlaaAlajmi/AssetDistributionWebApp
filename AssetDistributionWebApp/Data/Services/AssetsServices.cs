using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetDistributionWebApp.Data.Services
{
    public class AssetsServices : IAssetsServices
    {
        private readonly AppDbContext _context;
        public AssetsServices(AppDbContext context)
        {
            _context = context;
        }
        public void Add(assets asset)
        {
            _context.assets.Add(asset);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<assets>> GetAll()
        {
            var result = await _context.assets.ToListAsync();
            return result;
        }

        public assets GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
