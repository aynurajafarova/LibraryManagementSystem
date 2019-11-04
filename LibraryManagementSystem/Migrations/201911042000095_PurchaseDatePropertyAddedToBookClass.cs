namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseDatePropertyAddedToBookClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PurchaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PurchaseDate");
        }
    }
}
