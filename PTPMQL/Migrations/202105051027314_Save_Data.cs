namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Save_Data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        HovaTen = c.String(nullable: false, maxLength: 128),
                        GioiTinh = c.String(),
                        HoChieu = c.String(),
                    })
                .PrimaryKey(t => t.HovaTen);
            
            DropColumn("dbo.QuanLiChuyenBays", "Address");
            DropTable("dbo.KhachHangs");
            
        }
        
        public override void Down()
        {
            
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangID = c.String(nullable: false, maxLength: 15),
                        TenKhachHang = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
            AddColumn("dbo.QuanLiChuyenBays", "Address", c => c.String());
            DropTable("dbo.Passengers");
        }
    }
}
