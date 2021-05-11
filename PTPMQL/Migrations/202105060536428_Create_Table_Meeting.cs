namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Meeting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        IDNhanVien = c.String(nullable: false, maxLength: 128),
                        ChuDeHop = c.String(),
                        NoiDungHop = c.String(),
                    })
                .PrimaryKey(t => t.IDNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meetings");
        }
    }
}
