namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedUserIdColumnToGuardianTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guardians", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guardians", "UserId");
        }
    }
}
