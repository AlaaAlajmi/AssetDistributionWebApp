using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Models
{
	public class assets
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
		public int amount { get; set; }
		public string imageurl { get; set; }
		public string description { get; set; }
		public string focalPoint { get; set; }
	}
}
