namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedPercentToDoubleInGradebook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gradebooks", "PercentGrade", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gradebooks", "PercentGrade", c => c.Int());
        }
    }
}
