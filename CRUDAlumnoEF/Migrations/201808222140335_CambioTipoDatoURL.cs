namespace CRUDAlumnoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioTipoDatoURL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnoes", "Url", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnoes", "Url", c => c.Int(nullable: false));
        }
    }
}
