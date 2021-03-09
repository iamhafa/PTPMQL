namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Account_QueQuan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        IDNhanVien = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IDNhanVien);
            
            AddColumn("dbo.Accounts", "QueQuan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "QueQuan");
            DropTable("dbo.NhanViens");
        }
    }
}
