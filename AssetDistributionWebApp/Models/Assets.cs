using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Models
{
	public class Assets
	{
		public string Name { get; set; }
		public int Amount { get; set; }
		public string ImageUrl { get; set; }
		public string FocalPoint { get; set; }
	}
}
