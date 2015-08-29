using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI.WebControls;

namespace Coupons.Web.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Company Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Company E-mail Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public byte[] DisplayPicture { get; set; }

        [Display(Name = "Physical Address")]
        public string Address { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}