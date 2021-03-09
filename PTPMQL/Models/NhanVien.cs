using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string IDNhanVien { get; set; }
        public string HoTenNV { get; set; }
        public string ChucVu { get; set; }
        public string BoPhan { get; set; }
    }
}