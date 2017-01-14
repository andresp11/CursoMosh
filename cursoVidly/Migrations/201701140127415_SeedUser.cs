namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
                    //Usuarios
                Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'21d95017-aa40-4628-b9cd-cccc8070f1d7', N'guest@guest.com', 0, N'ANQHXxsyjtrROhLpIKOl9Ec2Qz1oMZeQgWm0AJAJaT0Tai7FBq8BauYMW3/ICaRIGA==', N'd30bf054-2667-48d3-8212-aafbc96f28da', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')
                      INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e64d3bc-c39a-4a26-9381-8314c81b87f8', N'ANDRES.PONCE.DE.LEON.HUERTA@GMAIL.COM', 0, N'AOz8uq9r42dN6sbZOz+cVM6ju3Y+kSJKIFO+7RHybevh12gL8yytpjZH4nFiUPfV5A==', N'5d41d23a-8ad5-4e3f-a3a9-688d2dddfb89', NULL, 0, 0, NULL, 1, 0, N'ANDRES.PONCE.DE.LEON.HUERTA@GMAIL.COM')

                      INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'31d86b61-6a47-420d-84eb-9de21d46a234', N'CanManageMovies')

                      INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e64d3bc-c39a-4a26-9381-8314c81b87f8', N'31d86b61-6a47-420d-84eb-9de21d46a234')
                    ");

        }
        
        public override void Down()
        {
        }
    }
}
