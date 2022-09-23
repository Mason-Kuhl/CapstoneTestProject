namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [StudentId], [DisplayName], [CurrentTier]) VALUES (N'9524009a-0430-4db1-95b0-8cd45b4a8719', N'guest2@gmail.com', 0, N'AJGOlESi5rJrXBcEIvqQ4N7NMFTOWB/lOG6DoDD9hkFOakKkzrTF39Ml/odpYFVTLQ==', N'3e0d7a74-bdc4-4bc0-a57d-4698f84c6205', NULL, 0, 0, NULL, 1, 0, N'guest2@gmail.com', N'guest2', N'guest2', 837484, NULL, 1)
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [StudentId], [DisplayName], [CurrentTier]) VALUES (N'd3e2bcf6-59d0-485d-a5dc-d85ffb5ee79f', N'admin@admin.com', 0, N'ALlgMcfk5x584xokIJYKCo/DX3IBpm8GleglPTgfd0e/sSRgaEruu0ebM2v7n4ZZew==', N'0fc165f0-5391-4ae3-bc9e-dd722bf1e00d', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com', N'Admin', N'Account', 0, N'Admin', 1)

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'154cae40-33d0-4241-baf5-85f02546fac4', N'Admin')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd3e2bcf6-59d0-485d-a5dc-d85ffb5ee79f', N'154cae40-33d0-4241-baf5-85f02546fac4')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
