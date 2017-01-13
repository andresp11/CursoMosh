namespace cursoVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addissubscribretocustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSuscribibedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSuscribibedToNewsLetter");
        }
    }
}
