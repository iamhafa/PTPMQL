namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Meeting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meetings", "MaChuyenBay", c => c.String());
            AddColumn("dbo.Meetings", "DateTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meetings", "DateTime");
            DropColumn("dbo.Meetings", "MaChuyenBay");
        }
    }
}
