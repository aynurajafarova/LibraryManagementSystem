namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderClassWasCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        ReturnDate = c.DateTime(nullable: false, storeType: "date"),
                        Cost = c.Decimal(nullable: false, storeType: "money"),
                        Returned = c.Boolean(nullable: false),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "MemberId" });
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropTable("dbo.Orders");
        }
    }
}
