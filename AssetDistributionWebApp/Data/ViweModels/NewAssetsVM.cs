using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Data.ViweModels
{
    public class NewAssetsVM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int assetid { get; set; }

        [Required]
        [Display(Name = "Asset Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public int amount { get; set; }

        [Required]
        [Display(Name = "File")]
        public string imageurl { get; set; }

        [Required]
        [Display(Name = "Discription")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Focal Point")]
        public string focalPoint { get; set; }
    
}
}
