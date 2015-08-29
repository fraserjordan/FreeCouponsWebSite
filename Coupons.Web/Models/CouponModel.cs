using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coupons.Web.Models
{
    public class CouponModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstItem { get; set; }

        [Required]
        public byte[] DisplayPicture { get; set; }

        [Required]
        public string SecondItem { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Conditions { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }
    }
}