namespace CRUDAlumnoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AlumnoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnoes");
        }
    }
}
