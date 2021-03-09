namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
