using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data.Base;
using AssetDistributionWebApp.Data.ViweModels;
using AssetDistributionWebApp.Models;
using Microsoft.EntityFrameworkCore;
using AssetDistributionWebApp.Data.Services;


namespace AssetDistributionWebApp.Data.Services
{
	public class AssetsService : EntityBaseRepository<assets>, IAssetService
	{
		private readonly AppDbContext _context;
		public AssetsService(AppDbContext context) : base(context) {

			_context = context;
		}
		public async Task AddNewAssetAsync(NewAssetsVM data)
        {
			var newAssets = new Assets()
			{

			};
        }
	}

}
