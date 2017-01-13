namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feedmovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name, GenreId, ReleaseDate, DateAdded,stock) values ('HangOver', 2, '2009/11/06',getdate(),5)");
            Sql("Insert into Movies (Name, GenreId, ReleaseDate, DateAdded,stock) values ('Macario', 3, '1960/06/09',getdate(),8)");
            Sql("Insert into Movies (Name, GenreId, ReleaseDate, DateAdded,stock) values ('Back to the future', 2, '1985/12/02',getdate(),2)");
            Sql("Insert into Movies (Name, GenreId, ReleaseDate, DateAdded,stock) values ('Back to the future 2', 1, '1989/12/22',getdate(),3)");
            Sql("Insert into Movies (Name, GenreId, ReleaseDate, DateAdded,stock) values ('Back to the future 3', 4, '1990/11/30',getdate(),4)");
        }
        
        public override void Down()
        {
        }
    }
}
