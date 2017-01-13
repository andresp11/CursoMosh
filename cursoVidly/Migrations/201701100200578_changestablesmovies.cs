namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestablesmovies : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "genre_Id" });
            DropColumn("dbo.Movies", "GenreId");
            RenameColumn(table: "dbo.Movies", name: "genre_Id", newName: "GenreId");
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Movies", "GenreId", c => c.Boolean(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "genre_Id");
            AddColumn("dbo.Movies", "GenreId", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Movies", "genre_Id");
        }
    }
}
