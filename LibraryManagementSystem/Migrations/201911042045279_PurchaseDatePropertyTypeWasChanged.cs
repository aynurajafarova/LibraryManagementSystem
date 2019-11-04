namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseDatePropertyTypeWasChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "PurchaseDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "PurchaseDate", c => c.DateTime(nullable: false));
        }
    }
}
