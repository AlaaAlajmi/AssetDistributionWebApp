using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Models;

namespace AssetDistributionWebApp.Data.Services
{
    public interface IAssetsServices
    {
        Task<IEnumerable<assets>> GetAll();
        assets GetByID(int id);
        void Add(assets asset);

    }
}
