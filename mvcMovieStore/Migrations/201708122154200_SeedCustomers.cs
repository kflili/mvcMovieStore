namespace mvcMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT INTO [dbo].[Customers] ([ID], [Name], [IsSubscribedToNewsletter], [MembershipTypeID], [Birthdate]) VALUES (2, N'Mary William', 1, 2, NULL)
INSERT INTO [dbo].[Customers] ([ID], [Name], [IsSubscribedToNewsletter], [MembershipTypeID], [Birthdate]) VALUES (3, N'Joe Gaga', 0, 1, N'1980-01-01 00:00:00')
SET IDENTITY_INSERT [dbo].[Customers] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
