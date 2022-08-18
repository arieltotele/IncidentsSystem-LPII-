namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateinpuestoentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento");
            DropIndex("dbo.Puesto", new[] { "Departamentoid" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Puesto", "Departamentoid");
            AddForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento", "Id", cascadeDelete: true);
        }
    }
}
