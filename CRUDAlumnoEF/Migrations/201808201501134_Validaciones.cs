namespace CRUDAlumnoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validaciones : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnoes", "Nombre", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Alumnoes", "Apellido", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Alumnoes", "Direccion", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Alumnoes", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Alumnoes", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnoes", "Email", c => c.String());
            AlterColumn("dbo.Alumnoes", "Telefono", c => c.String());
            AlterColumn("dbo.Alumnoes", "Direccion", c => c.String());
            AlterColumn("dbo.Alumnoes", "Apellido", c => c.String());
            AlterColumn("dbo.Alumnoes", "Nombre", c => c.String());
        }
    }
}
