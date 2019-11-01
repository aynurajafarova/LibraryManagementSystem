namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttributesAddedToTheBookAndLibrarianClassesProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Librarians", "Username", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Librarians", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Librarians", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Librarians", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Librarians", "Phone", c => c.String());
            AlterColumn("dbo.Librarians", "Password", c => c.String());
            AlterColumn("dbo.Librarians", "Email", c => c.String());
            AlterColumn("dbo.Librarians", "Username", c => c.String());
            AlterColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Name", c => c.String());
        }
    }
}
