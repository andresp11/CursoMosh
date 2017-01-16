namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnMovieAvailabilityforce : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable ", c => c.Int(nullable: false));
            Sql("update Movies set NumberAvailable  = stock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable ");
        }
    }
}
