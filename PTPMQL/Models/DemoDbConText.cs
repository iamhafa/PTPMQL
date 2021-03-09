using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class DemoDbConText : DbContext
    {
        public DemoDbConText()
            : base("name=DemoDbConText")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<QuanLiChuyenBay> QuanLiChuyenBays { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<QuanLiHangGui> QuanLiHangGuis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
