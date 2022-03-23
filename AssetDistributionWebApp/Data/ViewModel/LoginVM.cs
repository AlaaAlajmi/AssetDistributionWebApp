using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssetDistributionWebApp.Data.ViewModel
{
    public class LoginVM
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "! Please enter a vaild email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "! Please enter a vaild password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
