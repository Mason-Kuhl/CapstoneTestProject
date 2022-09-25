namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIncrementingIdToGuardiansTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Guardians");
            AddColumn("dbo.Guardians", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Guardians", "UserId", c => c.String());
            AddPrimaryKey("dbo.Guardians", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Guardians");
            AlterColumn("dbo.Guardians", "UserId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Guardians", "Id");
            AddPrimaryKey("dbo.Guardians", "UserId");
        }
    }
}
