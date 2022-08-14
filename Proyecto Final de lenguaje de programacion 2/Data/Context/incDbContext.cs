using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
