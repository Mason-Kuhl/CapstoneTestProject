namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRolesToRoleTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'afe4de63-f2c7-47ec-a1c6-ea0ab4d56ebc', N'Guardian')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b25d3c9c-e3d0-47f2-9de3-167954cb8668', N'Student')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'329f7f2f-925b-4fa4-81da-05472d4e4e10', N'Teacher')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
