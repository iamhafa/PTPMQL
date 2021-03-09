namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_NhanVien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "HoTenNV", c => c.String());
            AddColumn("dbo.NhanViens", "ChucVu", c => c.String());
            AddColumn("dbo.NhanViens", "BoPhan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "BoPhan");
            DropColumn("dbo.NhanViens", "ChucVu");
            DropColumn("dbo.NhanViens", "HoTenNV");
        }
    }
}
