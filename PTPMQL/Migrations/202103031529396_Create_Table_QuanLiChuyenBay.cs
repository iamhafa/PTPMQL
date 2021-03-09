namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_QuanLiChuyenBay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanLiChuyenBays",
                c => new
                    {
                        MaChuyenBay = c.String(nullable: false, maxLength: 128),
                        DiemKhoiHanh = c.String(),
                        DiemDen = c.String(),
                        ThoiGianBay = c.Int(nullable: false),
                        ChoNgoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaChuyenBay);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuanLiChuyenBays");
        }
    }
}
