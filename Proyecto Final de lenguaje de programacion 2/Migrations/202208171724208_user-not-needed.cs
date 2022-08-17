namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usernotneeded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departamento", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Sla", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Prioridad", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Historial_Incidente", "usuario_Id", "dbo.UsuarioId");
            DropIndex("dbo.Departamento", new[] { "usuario_Id" });
            DropIndex("dbo.Historial_Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Prioridad", new[] { "usuario_Id" });
            DropIndex("dbo.Sla", new[] { "usuario_Id" });
            DropColumn("dbo.Departamento", "usuario_Id");
            DropColumn("dbo.Historial_Incidente", "usuario_Id");
            DropColumn("dbo.Incidente", "usuario_Id");
            DropColumn("dbo.Prioridad", "usuario_Id");
            DropColumn("dbo.Sla", "usuario_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sla", "usuario_Id", c => c.Int());
            AddColumn("dbo.Prioridad", "usuario_Id", c => c.Int());
            AddColumn("dbo.Incidente", "usuario_Id", c => c.Int());
            AddColumn("dbo.Historial_Incidente", "usuario_Id", c => c.Int());
            AddColumn("dbo.Departamento", "usuario_Id", c => c.Int());
            CreateIndex("dbo.Sla", "usuario_Id");
            CreateIndex("dbo.Prioridad", "usuario_Id");
            CreateIndex("dbo.Incidente", "usuario_Id");
            CreateIndex("dbo.Historial_Incidente", "usuario_Id");
            CreateIndex("dbo.Departamento", "usuario_Id");
            AddForeignKey("dbo.Historial_Incidente", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Incidente", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Prioridad", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Sla", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Departamento", "usuario_Id", "dbo.UsuarioId", "Id");
        }
    }
}
