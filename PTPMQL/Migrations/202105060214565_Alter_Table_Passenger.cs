namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_Passenger : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Passengers");
            AlterColumn("dbo.Passengers", "HovaTen", c => c.String());
            AlterColumn("dbo.Passengers", "HoChieu", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Passengers", "HoChieu");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Passengers");
            AlterColumn("dbo.Passengers", "HoChieu", c => c.String());
            AlterColumn("dbo.Passengers", "HovaTen", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Passengers", "HovaTen");
        }
    }
}
