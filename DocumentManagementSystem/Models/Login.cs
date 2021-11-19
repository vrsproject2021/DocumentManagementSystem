using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocumentManagementSystem.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "UserName")]

        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]

        //[Display(Name = "Role")]
        //public string Role { get; set; }
        //[Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
    
