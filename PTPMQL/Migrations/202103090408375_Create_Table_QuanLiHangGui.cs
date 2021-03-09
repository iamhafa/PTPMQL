namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_QuanLiHangGui : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanLiHangGuis",
                c => new
                    {
                        MaHangGui = c.String(nullable: false, maxLength: 128),
                        NgayGioGuiHang = c.String(),
                        CanNangHangGui = c.String(),
                        XacNhanHopLe = c.String(),
                    })
                .PrimaryKey(t => t.MaHangGui);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuanLiHangGuis");
        }
    }
}
