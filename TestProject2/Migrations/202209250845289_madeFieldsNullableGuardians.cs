namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeFieldsNullableGuardians : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guardians", "StudentId", c => c.Int());
            AlterColumn("dbo.Guardians", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guardians", "StudentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Guardians", "UserId", c => c.String(nullable: false));
        }
    }
}
