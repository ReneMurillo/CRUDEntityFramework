namespace CRUDAlumnoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoNuevo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnoes", "Url", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumnoes", "Url");
        }
    }
}
