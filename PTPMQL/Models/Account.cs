using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PTPMQL.Models
{
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "Tên tài khoản không được để trống")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}