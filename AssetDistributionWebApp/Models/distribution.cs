using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Models
{
    public class distribution
    {
        [Key]
        public int distributionid { get; set; }
        
        public int amount { get; set; }
        public string useremail { get; set; }
        public string senderemail { get; set; }
        public string approved { get; set; }

        //FK
        public int assetid { get; set; }
        [ForeignKey("assetid")]
        public assets assets { get; set; }

        
    }
}
