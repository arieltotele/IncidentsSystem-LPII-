namespace Proyecto_Final_de_lenguaje_de_programacion_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primaria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Departamentoid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Departamentoid);
            
            CreateTable(
                "dbo.Puesto",
                c => new
                    {
                        Puestoid = c.Int(nullable: false, identity: true),
                        Departamentoid = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Puestoid)
                .ForeignKey("dbo.Departamento", t => t.Departamentoid, cascadeDelete: true)
                .Index(t => t.Departamentoid);
            
            CreateTable(
                "dbo.Historial Incidente",
                c => new
                    {
                        HistorialIncidenteId = c.Int(nullable: false, identity: true),
                        IncidenteId = c.Int(nullable: false),
                        Comentario = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HistorialIncidenteId)
                .ForeignKey("dbo.Incidente", t => t.IncidenteId, cascadeDelete: true)
                .Index(t => t.IncidenteId);
            
            CreateTable(
                "dbo.Incidente",
                c => new
                    {
                        IncidenteId = c.Int(nullable: false, identity: true),
                        UsuarioReportadoId = c.Int(nullable: false),
                        UsuarioAsignadoId = c.Int(nullable: false),
                        PrioridadId = c.Int(nullable: false),
                        DepartamentoId = c.Int(nullable: false),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        FechaCierre = c.DateTimeOffset(nullable: false, precision: 7),
                        ComentarioCierre = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IncidenteId);
            
            CreateTable(
                "dbo.Prioridad",
                c => new
                    {
                        PrioridadId = c.Int(nullable: false, identity: true),
                        SladId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                        Sla_Slaid = c.Int(),
                    })
                .PrimaryKey(t => t.PrioridadId)
                .ForeignKey("dbo.Sla", t => t.Sla_Slaid)
                .Index(t => t.Sla_Slaid);
            
            CreateTable(
                "dbo.Sla",
                c => new
                    {
                        Slaid = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        CantidadHoras = c.Int(nullable: false),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        Creadopor = c.Int(nullable: false),
                        Modificadopor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Slaid);
            
            CreateTable(
                "dbo.usuarioId",
                c => new
                    {
                        usuarioId = c.Int(nullable: false, identity: true),
                        puestoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        apellido = c.String(),
                        Cedula = c.String(),
                        Correo = c.String(),
                        telefono = c.String(),
                        FechaNacimineto = c.DateTime(nullable: false),
                        nombreusuario = c.String(),
                        contraseña = c.String(),
                        Estatus = c.String(),
                        Borrado = c.Byte(nullable: false),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                        FechaModificacion = c.DateTimeOffset(nullable: false, precision: 7),
                        creadopor = c.Int(nullable: false),
                        Modificadopo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.usuarioId)
                .ForeignKey("dbo.Puesto", t => t.puestoId, cascadeDelete: true)
                .Index(t => t.puestoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuarioId", "puestoId", "dbo.Puesto");
            DropForeignKey("dbo.Prioridad", "Sla_Slaid", "dbo.Sla");
            DropForeignKey("dbo.Historial Incidente", "IncidenteId", "dbo.Incidente");
            DropForeignKey("dbo.Puesto", "Departamentoid", "dbo.Departamento");
            DropIndex("dbo.usuarioId", new[] { "puestoId" });
            DropIndex("dbo.Prioridad", new[] { "Sla_Slaid" });
            DropIndex("dbo.Historial Incidente", new[] { "IncidenteId" });
            DropIndex("dbo.Puesto", new[] { "Departamentoid" });
            DropTable("dbo.usuarioId");
            DropTable("dbo.Sla");
            DropTable("dbo.Prioridad");
            DropTable("dbo.Incidente");
            DropTable("dbo.Historial Incidente");
            DropTable("dbo.Puesto");
            DropTable("dbo.Departamento");
        }
    }
}
