namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MustBeReturnedPropertyAddedToTheOrderClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "MustBeReturned", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "MustBeReturned");
        }
    }
}
