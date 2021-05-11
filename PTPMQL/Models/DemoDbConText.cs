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
        public virtual DbSet<QuanLiHangGui> QuanLiHangGuis { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<CheckAccount> CheckAccounts { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
