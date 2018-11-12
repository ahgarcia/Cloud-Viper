using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudViper.Web.Models
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "The field LoginID is required")]
        [StringLength(20, ErrorMessage = "The field LoginID must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LoginID must be a string")]
        public String LoginID { get; set; }

        [Required(ErrorMessage = "The field PasswordEncrypted is required")]
        [StringLength(256, ErrorMessage = "The field PasswordEncrypted must have max length of 256 characters")]
        [DataType(DataType.Password, ErrorMessage = "The field PasswordEncrypted must be a Password valid")]
        public String PasswordEncrypted { get; set; }

        [Required(ErrorMessage = "The field RoleId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field RoleId must be a number.")]
        public int RoleId { get; set; }
    }
}
