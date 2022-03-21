using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data.Base;
using AssetDistributionWebApp.Models;
using AssetDistributionWebApp.Data.Services;

namespace AssetDistributionWebApp.Data.Services
{
	public interface IAssetService: IEntityBaseRepository<assets>
	{
		Task<assets> 
	}
}
