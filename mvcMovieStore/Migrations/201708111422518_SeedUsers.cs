namespace mvcMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            // AspNetUsers
            // AspNetRoles
            // AspNetUserRoles
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37ff957e-f8e7-4a12-a957-5270336b60e4', N'admin@test.com', 0, N'AIiN0wfiG/Yf3+rjHnwlGk65Lkw/oxcjHTTWOcIi2AXCex0e/Aa+AyzM++Qany2RJQ==', N'6281b343-4803-461b-a20f-917bb71db58d', NULL, 0, 0, NULL, 1, 0, N'admin@test.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'87deb850-1b2a-4be3-8db0-37d164d260c2', N'guest@test.com', 0, N'AEotXLkLbvxE3OiSg6revrqpE758F3bvdb8TemyVeExzVbEW1w5iYYA+uitRVpbf4Q==', N'5b1e6c65-5f5e-432b-b933-60533ad73f5f', NULL, 0, 0, NULL, 1, 0, N'guest@test.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'509c5e19-f924-47a2-accd-4663a487bbb1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37ff957e-f8e7-4a12-a957-5270336b60e4', N'509c5e19-f924-47a2-accd-4663a487bbb1')

");
        }
        
        public override void Down()
        {
        }
    }
}
