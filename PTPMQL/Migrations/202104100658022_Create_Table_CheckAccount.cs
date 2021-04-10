namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_CheckAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckAccounts",
                c => new
                    {
                        UserName1 = c.String(nullable: false, maxLength: 128),
                        Password1 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName1);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CheckAccounts");
        }
    }
}
