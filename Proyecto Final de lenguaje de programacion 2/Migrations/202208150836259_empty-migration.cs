﻿namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emptymigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Historial Incidente", newName: "Historial_Incidente");
            DropForeignKey("dbo.usuarioId", "puestoId", "dbo.Puesto");
            DropForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento");
            DropForeignKey("dbo.Historial Incidente", "IncidenteId", "dbo.Incidente");
            DropForeignKey("dbo.Prioridad", "Sla_Slaid", "dbo.Sla");
            DropIndex("dbo.UsuarioId", new[] { "puestoId" });
            RenameColumn(table: "dbo.Prioridad", name: "Sla_Slaid", newName: "Sla_Id");
            RenameColumn(table: "dbo.Puesto", name: "puestoId", newName: "Id");
            RenameIndex(table: "dbo.Prioridad", name: "IX_Sla_Slaid", newName: "IX_Sla_Id");
            DropPrimaryKey("dbo.Departamento");
            DropPrimaryKey("dbo.Puesto");
            DropPrimaryKey("dbo.Historial_Incidente");
            DropPrimaryKey("dbo.Incidente");
            DropPrimaryKey("dbo.Prioridad");
            DropPrimaryKey("dbo.Sla");
            DropPrimaryKey("dbo.UsuarioId");
            AddColumn("dbo.Departamento", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Departamento", "usuario_Id", c => c.Int());
            AddColumn("dbo.Historial_Incidente", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Historial_Incidente", "usuario_Id", c => c.Int());
            AddColumn("dbo.Incidente", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Incidente", "usuario_Id", c => c.Int());
            AddColumn("dbo.Prioridad", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Prioridad", "usuario_Id", c => c.Int());
            AddColumn("dbo.Sla", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Sla", "usuario_Id", c => c.Int());
            AddColumn("dbo.UsuarioId", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.UsuarioId", "Modificadopor", c => c.Int(nullable: false));
            AlterColumn("dbo.Departamento", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Departamento", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Departamento", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Puesto", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Puesto", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Puesto", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Puesto", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Historial_Incidente", "Comentario", c => c.String(nullable: false, maxLength: 500, unicode: false));
            AlterColumn("dbo.Historial_Incidente", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Historial_Incidente", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Incidente", "Titulo", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Incidente", "Descripcion", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Incidente", "ComentarioCierre", c => c.String(nullable: false, maxLength: 500, unicode: false));
            AlterColumn("dbo.Incidente", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Incidente", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Prioridad", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Prioridad", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Prioridad", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Sla", "Descripcion", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Sla", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Sla", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.UsuarioId", "Nombre", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.UsuarioId", "Apellido", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.UsuarioId", "Cedula", c => c.String(nullable: false, maxLength: 11, unicode: false));
            AlterColumn("dbo.UsuarioId", "Correo", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.UsuarioId", "Telefono", c => c.String(maxLength: 15, unicode: false));
            AlterColumn("dbo.UsuarioId", "nombreusuario", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.UsuarioId", "contraseña", c => c.String(nullable: false, maxLength: 500, unicode: false));
            AlterColumn("dbo.UsuarioId", "Estatus", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.UsuarioId", "FechaModificacion", c => c.DateTimeOffset(precision: 7));
            AddPrimaryKey("dbo.Departamento", "Id");
            AddPrimaryKey("dbo.Puesto", "Id");
            AddPrimaryKey("dbo.Historial_Incidente", "Id");
            AddPrimaryKey("dbo.Incidente", "Id");
            AddPrimaryKey("dbo.Prioridad", "Id");
            AddPrimaryKey("dbo.Sla", "Id");
            AddPrimaryKey("dbo.UsuarioId", "Id");
            CreateIndex("dbo.Departamento", "usuario_Id");
            CreateIndex("dbo.Puesto", "Id");
            CreateIndex("dbo.Historial_Incidente", "usuario_Id");
            CreateIndex("dbo.Incidente", "PrioridadId");
            CreateIndex("dbo.Incidente", "DepartamentoId");
            CreateIndex("dbo.Incidente", "usuario_Id");
            CreateIndex("dbo.Prioridad", "usuario_Id");
            CreateIndex("dbo.Sla", "usuario_Id");
            AddForeignKey("dbo.Departamento", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Incidente", "DepartamentoId", "dbo.Departamento", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sla", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Prioridad", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Incidente", "PrioridadId", "dbo.Prioridad", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Incidente", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Historial_Incidente", "usuario_Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Puesto", "Id", "dbo.UsuarioId", "Id");
            AddForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Historial_Incidente", "IncidenteId", "dbo.Incidente", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Prioridad", "Sla_Id", "dbo.Sla", "Id");
            DropColumn("dbo.Departamento", "Departamentoid");
            DropColumn("dbo.Historial_Incidente", "HistorialIncidenteId");
            DropColumn("dbo.Incidente", "IncidenteId");
            DropColumn("dbo.Prioridad", "PrioridadId");
            DropColumn("dbo.Sla", "Slaid");
            DropColumn("dbo.UsuarioId", "usuarioId");
            DropColumn("dbo.UsuarioId", "Modificadopo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UsuarioId", "Modificadopo", c => c.Int(nullable: false));
            AddColumn("dbo.UsuarioId", "usuarioId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Sla", "Slaid", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Prioridad", "PrioridadId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Incidente", "IncidenteId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Historial_Incidente", "HistorialIncidenteId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Departamento", "Departamentoid", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Prioridad", "Sla_Id", "dbo.Sla");
            DropForeignKey("dbo.Historial_Incidente", "IncidenteId", "dbo.Incidente");
            DropForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento");
            DropForeignKey("dbo.Puesto", "Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Historial_Incidente", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "PrioridadId", "dbo.Prioridad");
            DropForeignKey("dbo.Prioridad", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Sla", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "DepartamentoId", "dbo.Departamento");
            DropForeignKey("dbo.Departamento", "usuario_Id", "dbo.UsuarioId");
            DropIndex("dbo.Sla", new[] { "usuario_Id" });
            DropIndex("dbo.Prioridad", new[] { "usuario_Id" });
            DropIndex("dbo.Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Incidente", new[] { "DepartamentoId" });
            DropIndex("dbo.Incidente", new[] { "PrioridadId" });
            DropIndex("dbo.Historial_Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Puesto", new[] { "Id" });
            DropIndex("dbo.Departamento", new[] { "usuario_Id" });
            DropPrimaryKey("dbo.UsuarioId");
            DropPrimaryKey("dbo.Sla");
            DropPrimaryKey("dbo.Prioridad");
            DropPrimaryKey("dbo.Incidente");
            DropPrimaryKey("dbo.Historial_Incidente");
            DropPrimaryKey("dbo.Puesto");
            DropPrimaryKey("dbo.Departamento");
            AlterColumn("dbo.UsuarioId", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.UsuarioId", "Estatus", c => c.String());
            AlterColumn("dbo.UsuarioId", "contraseña", c => c.String());
            AlterColumn("dbo.UsuarioId", "nombreusuario", c => c.String());
            AlterColumn("dbo.UsuarioId", "Telefono", c => c.String());
            AlterColumn("dbo.UsuarioId", "Correo", c => c.String());
            AlterColumn("dbo.UsuarioId", "Cedula", c => c.String());
            AlterColumn("dbo.UsuarioId", "Apellido", c => c.String());
            AlterColumn("dbo.UsuarioId", "Nombre", c => c.String());
            AlterColumn("dbo.Sla", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Sla", "Estatus", c => c.String());
            AlterColumn("dbo.Sla", "Descripcion", c => c.String());
            AlterColumn("dbo.Prioridad", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Prioridad", "Estatus", c => c.String());
            AlterColumn("dbo.Prioridad", "Nombre", c => c.String());
            AlterColumn("dbo.Incidente", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Incidente", "Estatus", c => c.String());
            AlterColumn("dbo.Incidente", "ComentarioCierre", c => c.String());
            AlterColumn("dbo.Incidente", "Descripcion", c => c.String());
            AlterColumn("dbo.Incidente", "Titulo", c => c.String());
            AlterColumn("dbo.Historial_Incidente", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Historial_Incidente", "Estatus", c => c.String());
            AlterColumn("dbo.Historial_Incidente", "Comentario", c => c.String());
            AlterColumn("dbo.Puesto", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Puesto", "Estatus", c => c.String());
            AlterColumn("dbo.Puesto", "Nombre", c => c.String());
            AlterColumn("dbo.Puesto", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Departamento", "FechaModificacion", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Departamento", "Estatus", c => c.String());
            AlterColumn("dbo.Departamento", "Nombre", c => c.String());
            DropColumn("dbo.UsuarioId", "Modificadopor");
            DropColumn("dbo.UsuarioId", "Id");
            DropColumn("dbo.Sla", "usuario_Id");
            DropColumn("dbo.Sla", "Id");
            DropColumn("dbo.Prioridad", "usuario_Id");
            DropColumn("dbo.Prioridad", "Id");
            DropColumn("dbo.Incidente", "usuario_Id");
            DropColumn("dbo.Incidente", "Id");
            DropColumn("dbo.Historial_Incidente", "usuario_Id");
            DropColumn("dbo.Historial_Incidente", "Id");
            DropColumn("dbo.Departamento", "usuario_Id");
            DropColumn("dbo.Departamento", "Id");
            AddPrimaryKey("dbo.UsuarioId", "usuarioId");
            AddPrimaryKey("dbo.Sla", "Slaid");
            AddPrimaryKey("dbo.Prioridad", "PrioridadId");
            AddPrimaryKey("dbo.Incidente", "IncidenteId");
            AddPrimaryKey("dbo.Historial_Incidente", "HistorialIncidenteId");
            AddPrimaryKey("dbo.Puesto", "Puestoid");
            AddPrimaryKey("dbo.Departamento", "Departamentoid");
            RenameIndex(table: "dbo.Prioridad", name: "IX_Sla_Id", newName: "IX_Sla_Slaid");
            RenameColumn(table: "dbo.Puesto", name: "Id", newName: "puestoId");
            RenameColumn(table: "dbo.Prioridad", name: "Sla_Id", newName: "Sla_Slaid");
            CreateIndex("dbo.UsuarioId", "puestoId");
            AddForeignKey("dbo.Prioridad", "Sla_Slaid", "dbo.Sla", "Slaid");
            AddForeignKey("dbo.Historial Incidente", "IncidenteId", "dbo.Incidente", "IncidenteId", cascadeDelete: true);
            AddForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento", "Departamentoid", cascadeDelete: true);
            AddForeignKey("dbo.usuarioId", "puestoId", "dbo.Puesto", "Puestoid", cascadeDelete: true);
            RenameTable(name: "dbo.Historial_Incidente", newName: "Historial Incidente");
        }
    }
}