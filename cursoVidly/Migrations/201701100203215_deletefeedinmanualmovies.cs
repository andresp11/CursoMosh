namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletefeedinmanualmovies : DbMigration
    {
        public override void Up()
        {
            Sql("delete from movies where id < 13");
        }
        
        public override void Down()
        {
        }
    }
}
