namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnsToQuestionsClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Assessment_Id", c => c.String(nullable: true));
            AddColumn("dbo.Questions", "Gradebook_Id", c => c.String(nullable: true));
            AddColumn("dbo.Questions", "Gradebook_Id1", c => c.String(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.Questions", "Assessment_Id");
            DropColumn("dbo.Questions", "Gradebook_Id");
            DropColumn("dbo.Questions", "Gradebook_Id1");
        }
    }
}
