namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_QuanLiChuyenBay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuanLiChuyenBays", "SoHanhKhach", c => c.String());
            AddColumn("dbo.QuanLiChuyenBays", "ThoiGianXuatPhat", c => c.String());
            DropColumn("dbo.QuanLiChuyenBays", "ThoiGianBay");
            DropColumn("dbo.QuanLiChuyenBays", "ChoNgoi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuanLiChuyenBays", "ChoNgoi", c => c.Int(nullable: false));
            AddColumn("dbo.QuanLiChuyenBays", "ThoiGianBay", c => c.Int(nullable: false));
            DropColumn("dbo.QuanLiChuyenBays", "ThoiGianXuatPhat");
            DropColumn("dbo.QuanLiChuyenBays", "SoHanhKhach");
        }
    }
}
