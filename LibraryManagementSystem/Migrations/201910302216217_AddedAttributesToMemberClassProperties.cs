namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToMemberClassProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Fullname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "Email", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Members", "Phone", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Members", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Members", "Phone", c => c.String());
            AlterColumn("dbo.Members", "Email", c => c.String());
            AlterColumn("dbo.Members", "Address", c => c.String());
            AlterColumn("dbo.Members", "Fullname", c => c.String());
        }
    }
}
