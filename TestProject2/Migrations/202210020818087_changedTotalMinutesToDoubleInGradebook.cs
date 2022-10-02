namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedTotalMinutesToDoubleInGradebook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gradebooks", "Minutes", c => c.Double(nullable: false));
            DropColumn("dbo.Gradebooks", "TotalMinutes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gradebooks", "TotalMinutes", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gradebooks", "Minutes");
        }
    }
}
