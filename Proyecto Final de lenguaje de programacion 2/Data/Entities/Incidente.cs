using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    [Table("Incidente")] 

    public class Incidente
    {
        public int IncidenteId { get; set; }

        public int UsuarioReportadoId { get; set; }

        public int UsuarioAsignadoId { get; set; }

        public int PrioridadId { get; set; }

        public int DepartamentoId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public DateTimeOffset FechaCierre { get; set; }

        public string ComentarioCierre { get; set; }

        public string Estatus { get; set; }

        public byte Borrado { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset FechaModificacion { get; set; }

        public int Creadopor { get; set; }

        public int Modificadopor { get; set; }
    }
}
