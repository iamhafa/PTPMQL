namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_CheckAccount : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CheckAccounts");
            AddColumn("dbo.CheckAccounts", "CheckUserName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.CheckAccounts", "CheckPassword", c => c.String(nullable: false));
            AddPrimaryKey("dbo.CheckAccounts", "CheckUserName");
            DropColumn("dbo.CheckAccounts", "UserName1");
            DropColumn("dbo.CheckAccounts", "Password1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CheckAccounts", "Password1", c => c.String(nullable: false));
            AddColumn("dbo.CheckAccounts", "UserName1", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.CheckAccounts");
            DropColumn("dbo.CheckAccounts", "CheckPassword");
            DropColumn("dbo.CheckAccounts", "CheckUserName");
            AddPrimaryKey("dbo.CheckAccounts", "UserName1");
        }
    }
}
