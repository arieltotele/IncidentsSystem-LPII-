using System.Data.Entity;
using Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities;

namespace Proyecto_Final_de_lenguaje_de_programacion_2
{
    public class incDbContext:DbContext
    {
        public incDbContext()
            :base("name = pfinal ")
        {

        }
        public DbSet<Usuarioid> Usuarioids { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Puesto> Puestos { get; set; }
          
        public DbSet<Sla> slas { get; set; }

        public DbSet<Prioridad> prioridads { get; set; }

        public DbSet<Incidente> incidentes { get; set; }

        public DbSet<Historial_Incidente> historial_Incidentes { get; set; }


        //Fluent API use
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>()
                .HasKey(pk => pk.Id)
                .ToTable("Departamento");

            modelBuilder.Entity<Departamento>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Historial_Incidente>()
                .HasKey(pk => pk.Id)
                .ToTable("Historial_Incidente");

            modelBuilder.Entity<Incidente>()
                .HasKey(pk => pk.Id)
                .ToTable("Incidente");

            modelBuilder.Entity<Prioridad>()
                .HasKey(pk => pk.Id)
                .ToTable("Prioridad");

            modelBuilder.Entity<Puesto>()
                .HasKey(pk => pk.Id)
                .ToTable("Puesto");

            modelBuilder.Entity<Puesto>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Sla>()
                .HasKey(pk => pk.Id)
                .ToTable("Sla");

            modelBuilder.Entity<Sla>()
                .Property(p => p.Descripcion)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Usuarioid>()
                .HasKey(pk => pk.Id)
                .ToTable("UsuarioId");

            modelBuilder.Entity<Usuarioid>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Usuarioid>()
                .Property(p => p.Apellido)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnType("varchar");
        }


    }
}
