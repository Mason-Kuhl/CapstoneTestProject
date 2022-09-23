namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFieldsToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "StudentId", c => c.Int(nullable: true));
            AddColumn("dbo.AspNetUsers", "DisplayName", c => c.String(nullable: true));
            AddColumn("dbo.AspNetUsers", "CurrentTier", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CurrentTier");
            DropColumn("dbo.AspNetUsers", "DisplayName");
            DropColumn("dbo.AspNetUsers", "StudentId");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
