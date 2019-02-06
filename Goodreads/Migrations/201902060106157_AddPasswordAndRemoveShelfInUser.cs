namespace Goodreads.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPasswordAndRemoveShelfInUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "Bookshelf");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Bookshelf", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Password");
        }
    }
}
