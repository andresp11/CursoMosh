namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregacolumnadipsonibilidad : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(nullable: false));
            Sql("update Movies set NumberAvailable  = stock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieAvailability", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
