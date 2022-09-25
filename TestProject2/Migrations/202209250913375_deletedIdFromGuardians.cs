namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedIdFromGuardians : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Guardians");
            AlterColumn("dbo.Guardians", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Guardians", "UserId");
            DropColumn("dbo.Guardians", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guardians", "Id", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Guardians");
            AlterColumn("dbo.Guardians", "UserId", c => c.String());
            AddPrimaryKey("dbo.Guardians", "Id");
        }
    }
}
