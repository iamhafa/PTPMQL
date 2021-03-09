using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTPMQL.Models
{
    [Table("QuanLiChuyenBays")]
    public class QuanLiChuyenBay
    {
        [Key]
        public string MaChuyenBay { get; set; }
        public string DiemKhoiHanh { get; set; }
        public string DiemDen { get; set; }
        public int ThoiGianBay { get; set; }
        public int ChoNgoi { get; set; }
        public string Address { get; set; }
    }
}