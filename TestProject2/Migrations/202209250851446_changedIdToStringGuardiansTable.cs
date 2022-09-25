namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedIdToStringGuardiansTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Guardians");
            AlterColumn("dbo.Guardians", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Guardians", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Guardians");
            AlterColumn("dbo.Guardians", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Guardians", "Id");
        }
    }
}
