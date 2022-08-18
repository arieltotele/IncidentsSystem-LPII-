namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                    Creadopor = c.Int(nullable: false),
                    Modificadopor = c.Int(nullable: false),
                    Estatus = c.String(nullable: false, maxLength: 2),
                    Borrado = c.Byte(nullable: false),
                    FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                    FechaModificacion = c.DateTimeOffset(precision: 7),
                    usuario_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Puesto",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Departamentoid = c.Int(nullable: false),
                    Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                    Creadopor = c.Int(nullable: false),
                    Modificadopor = c.Int(nullable: false),
                    Estatus = c.String(nullable: false, maxLength: 2),
                    Borrado = c.Byte(nullable: false),
                    FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                    FechaModificacion = c.DateTimeOffset(precision: 7),
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioId",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        puestoId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cedula = c.String(nullable: false, maxLength: 11, unicode: false),
                        Correo = c.String(maxLength: 50, unicode: false),
                        Telefono = c.String(maxLength: 15, unicode: false),
                        FechaNacimineto = c.DateTime(nullable: false),
                        nombreusuario = c.String(nullable: false, maxLength: 100, unicode: false),
                        contraseña = c.String(nullable: false, maxLength: 500, unicode: false),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Historial_Incidente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncidenteId = c.Int(nullable: false),
                        Comentario = c.String(nullable: false, maxLength: 500, unicode: false),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(precision: 7),
                        usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Incidente", t => t.IncidenteId, cascadeDelete: true)
                .ForeignKey("dbo.UsuarioId", t => t.usuario_Id)
                .Index(t => t.IncidenteId)
                .Index(t => t.usuario_Id);
            
            CreateTable(
                "dbo.Incidente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioReportadoId = c.Int(nullable: false),
                        UsuarioAsignadoId = c.Int(nullable: false),
                        PrioridadId = c.Int(nullable: false),
                        DepartamentoId = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 8000, unicode: false),
                        FechaCierre = c.DateTimeOffset(nullable: false, precision: 7),
                        ComentarioCierre = c.String(nullable: false, maxLength: 500, unicode: false),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(precision: 7),
                        usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Prioridad", t => t.PrioridadId, cascadeDelete: true)
                .ForeignKey("dbo.UsuarioId", t => t.usuario_Id)
                .Index(t => t.PrioridadId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.usuario_Id);
            
            CreateTable(
                "dbo.Prioridad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SladId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(precision: 7),
                        Sla_Id = c.Int(),
                        usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sla", t => t.Sla_Id)
                .ForeignKey("dbo.UsuarioId", t => t.usuario_Id)
                .Index(t => t.Sla_Id)
                .Index(t => t.usuario_Id);
            
            CreateTable(
                "dbo.Sla",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 200, unicode: false),
                        CantidadHoras = c.Int(nullable: false),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(precision: 7),
                        usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UsuarioId", t => t.usuario_Id)
                .Index(t => t.usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Historial_Incidente", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Historial_Incidente", "IncidenteId", "dbo.Incidente");
            DropForeignKey("dbo.Incidente", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "PrioridadId", "dbo.Prioridad");
            DropForeignKey("dbo.Prioridad", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Prioridad", "Sla_Id", "dbo.Sla");
            DropForeignKey("dbo.Sla", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Incidente", "DepartamentoId", "dbo.Departamento");
            DropForeignKey("dbo.Departamento", "usuario_Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Puesto", "Id", "dbo.UsuarioId");
            DropForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento");
            DropIndex("dbo.Sla", new[] { "usuario_Id" });
            DropIndex("dbo.Prioridad", new[] { "usuario_Id" });
            DropIndex("dbo.Prioridad", new[] { "Sla_Id" });
            DropIndex("dbo.Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Incidente", new[] { "DepartamentoId" });
            DropIndex("dbo.Incidente", new[] { "PrioridadId" });
            DropIndex("dbo.Historial_Incidente", new[] { "usuario_Id" });
            DropIndex("dbo.Historial_Incidente", new[] { "IncidenteId" });
            DropIndex("dbo.Puesto", new[] { "Departamentoid" });
            DropIndex("dbo.Puesto", new[] { "Id" });
            DropIndex("dbo.Departamento", new[] { "usuario_Id" });
            DropTable("dbo.Sla");
            DropTable("dbo.Prioridad");
            DropTable("dbo.Incidente");
            DropTable("dbo.Historial_Incidente");
            DropTable("dbo.UsuarioId");
            DropTable("dbo.Puesto");
            DropTable("dbo.Departamento");
        }
    }
}
