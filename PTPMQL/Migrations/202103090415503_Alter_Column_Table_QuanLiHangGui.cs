namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_Table_QuanLiHangGui : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuanLiHangGuis", "TrongLuongHangGui", c => c.String());
            DropColumn("dbo.QuanLiHangGuis", "CanNangHangGui");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuanLiHangGuis", "CanNangHangGui", c => c.String());
            DropColumn("dbo.QuanLiHangGuis", "TrongLuongHangGui");
        }
    }
}
