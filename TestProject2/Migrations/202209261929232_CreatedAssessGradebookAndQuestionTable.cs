namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAssessGradebookAndQuestionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Tier = c.Int(),
                        AmountOfQuestions = c.Int(),
                        DueDate = c.DateTime(nullable: false),
                        Grade = c.Double(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        TotalMinutes = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tier = c.Int(),
                        MathQuestion = c.String(),
                        Answer = c.String(),
                        Assessment_Id = c.String(maxLength: 128),
                        Gradebook_Id = c.Int(),
                        Gradebook_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assessments", t => t.Assessment_Id)
                .ForeignKey("dbo.Gradebooks", t => t.Gradebook_Id)
                .ForeignKey("dbo.Gradebooks", t => t.Gradebook_Id1)
                .Index(t => t.Assessment_Id)
                .Index(t => t.Gradebook_Id)
                .Index(t => t.Gradebook_Id1);
            
            CreateTable(
                "dbo.Gradebooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssesmentId = c.Int(),
                        StudentId = c.Int(),
                        DateTaken = c.DateTime(nullable: false),
                        Correct = c.Int(),
                        Amount = c.Int(),
                        PercentGrade = c.Int(),
                        TotalMinutes = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Gradebook_Id1", "dbo.Gradebooks");
            DropForeignKey("dbo.Questions", "Gradebook_Id", "dbo.Gradebooks");
            DropForeignKey("dbo.Questions", "Assessment_Id", "dbo.Assessments");
            DropIndex("dbo.Questions", new[] { "Gradebook_Id1" });
            DropIndex("dbo.Questions", new[] { "Gradebook_Id" });
            DropIndex("dbo.Questions", new[] { "Assessment_Id" });
            DropTable("dbo.Gradebooks");
            DropTable("dbo.Questions");
            DropTable("dbo.Assessments");
        }
    }
}
