using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string IDKhachHang { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoBan { get; set; }
    }
}