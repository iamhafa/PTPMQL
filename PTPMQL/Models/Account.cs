﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTPMQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Account
    {
        [Required(ErrorMessage = "UserName không được để trống")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PassWord không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
