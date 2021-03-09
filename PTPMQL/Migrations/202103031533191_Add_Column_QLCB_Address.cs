namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_QLCB_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuanLiChuyenBays", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuanLiChuyenBays", "Address");
        }
    }
}
