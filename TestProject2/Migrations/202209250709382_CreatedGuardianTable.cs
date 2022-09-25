namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedGuardianTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guardians",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guardians");
        }
    }
}
