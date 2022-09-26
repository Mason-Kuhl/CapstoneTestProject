namespace TestProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeededQuestionsTable : DbMigration
    {
        public override void Up()
        {
        Sql (@"
          
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'1 + 1', N'2')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'2 + 2', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'5 + 3', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'3 + 4', N'7')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'9 + 1', N'10')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'6 + 3', N'9')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'4 + 2', N'6')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'1 + 2', N'3')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'7 + 3', N'10')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'2 + 7', N'9')

            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'1 - 1', N'0')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'3 - 2', N'1')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'4 - 1', N'3')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'6 - 3', N'3')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'4 - 2', N'2')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'8 - 4', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'9 - 5', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'7 - 3', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'9 - 1', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (1, N'3 - 1', N'2')

            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'3 * 3', N'9')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'4 * 2', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'5 * 4', N'20')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'2 * 6', N'12')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'7 * 7', N'49')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'8 * 5', N'40')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'4 * 3', N'12')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'9 * 2', N'18')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'1 * 1', N'1')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'5 * 0', N'0')

            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'20 / 4', N'5')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'49 / 7', N'7')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'45 / 9', N'5')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'10 / 5', N'2')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'12 / 3', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'50 / 5', N'10')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'36 / 6', N'6')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'16 / 4', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'28 / 7', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (2, N'32 / 4', N'8')

            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'2 + 2 * 6', N'14')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'3 + 2 * 4', N'11')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'10 - 4 / 2', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'2 + 6 / 3', N'4')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'22 - 2 / 1', N'20')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'8 * 4 + 2', N'34')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'4 / 2 * 4', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'3 + 3 * 2', N'9')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'10 / 2 * 4', N'20')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'12 + 6 * 2', N'24')

            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'7 * 7 + 1', N'50')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'3 * 3 + 1', N'10')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'2 * 5 / 5', N'2')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'2 + 5 * 0', N'2')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'5 + 5 * 2', N'15')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'6 * 6 / 3', N'12')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'10 + 5 * 2', N'20')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'15 / 3 + 5', N'10')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'16 / 4 * 2', N'8')
            INSERT INTO [dbo].[Questions] ([Tier], [MathQuestion], [Answer]) VALUES (3, N'10 + 10 / 5', N'12')
           
        ");
        }
        
        public override void Down()
        {
        }
    }
}
