using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("QuanLiHangGuis")]
    public class QuanLiHangGui
    {
        [Key]
        public string NgayGioGuiHang { get; set; }
        public string CanNangHangGui { get; set; }
    }
}