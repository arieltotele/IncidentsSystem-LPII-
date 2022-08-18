namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userrelationwithpuestodeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsuarioId", "puestoId", "dbo.Puesto");
            DropIndex("dbo.UsuarioId", new[] { "puestoId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.UsuarioId", "puestoId");
            AddForeignKey("dbo.UsuarioId", "puestoId", "dbo.Puesto", "Id", cascadeDelete: true);
        }
    }
}
