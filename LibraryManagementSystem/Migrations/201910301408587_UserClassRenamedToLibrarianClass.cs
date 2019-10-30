namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserClassRenamedToLibrarianClass : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Librarians");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Librarians", newName: "Users");
        }
    }
}
