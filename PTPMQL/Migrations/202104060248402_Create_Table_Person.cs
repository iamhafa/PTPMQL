namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Person : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NhanViens", newName: "Persons");
            DropPrimaryKey("dbo.Persons");
            AddColumn("dbo.Persons", "CCCD", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Persons", "FullName", c => c.String());
            AddColumn("dbo.Persons", "NhanVienID", c => c.String());
            AddColumn("dbo.Persons", "CongTy", c => c.String());
            AddColumn("dbo.Persons", "Address", c => c.String());
            AddColumn("dbo.Persons", "University", c => c.String());
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Persons", "CCCD");
            DropColumn("dbo.Accounts", "QueQuan");
            DropColumn("dbo.Persons", "IDNhanVien");
            DropColumn("dbo.Persons", "HoTenNV");
            DropColumn("dbo.Persons", "ChucVu");
            DropColumn("dbo.Persons", "BoPhan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "BoPhan", c => c.String());
            AddColumn("dbo.Persons", "ChucVu", c => c.String());
            AddColumn("dbo.Persons", "HoTenNV", c => c.String());
            AddColumn("dbo.Persons", "IDNhanVien", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Accounts", "QueQuan", c => c.String());
            DropPrimaryKey("dbo.Persons");
            DropColumn("dbo.Persons", "Discriminator");
            DropColumn("dbo.Persons", "University");
            DropColumn("dbo.Persons", "Address");
            DropColumn("dbo.Persons", "CongTy");
            DropColumn("dbo.Persons", "NhanVienID");
            DropColumn("dbo.Persons", "FullName");
            DropColumn("dbo.Persons", "CCCD");
            AddPrimaryKey("dbo.Persons", "IDNhanVien");
            RenameTable(name: "dbo.Persons", newName: "NhanViens");
        }
    }
}
