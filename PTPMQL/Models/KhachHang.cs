

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
    }
}