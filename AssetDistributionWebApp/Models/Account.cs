using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Models
{
	public class Account
	{
		[Key]
		public int accountid { get; set; }
		public string username { get; set; }
		public string password { get; set; }
	}
}
