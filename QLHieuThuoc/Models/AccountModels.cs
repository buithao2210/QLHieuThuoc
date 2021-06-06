using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLHieuThuoc.Models
{
    [Table("Accounts")]
    public class AccountModel
    {
        [Key]
        [Required(ErrorMessage = "Username is Required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(50)]
        public string RoleId { get; set; }
    }
}