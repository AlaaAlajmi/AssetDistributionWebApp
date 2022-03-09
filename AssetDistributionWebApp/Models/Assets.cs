using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Models
{
    public class assets
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int assetid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int amount { get; set; }

        public string imageurl { get; set; }

        public string description { get; set; }
        [Required]
        public string focalPoint { get; set; }
    }
}
