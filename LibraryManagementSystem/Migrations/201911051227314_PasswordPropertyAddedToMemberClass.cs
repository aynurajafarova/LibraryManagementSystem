namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PasswordPropertyAddedToMemberClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Password", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Password");
        }
    }
}
