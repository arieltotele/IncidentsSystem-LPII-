using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    [Table("Historial Incidente")]

    public class Historial_Incidente
    {
        [Key]

        public int HistorialIncidenteId { get; set; }

        public int IncidenteId { get; set; }
        public Incidente Incidente { get; set; }

        public string Comentario { get; set; }

        public string Estatus { get; set; }

        public byte Borrado { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset FechaModificacion { get; set; }

        public int Creadopor { get; set; }

        public int Modificadopor { get; set; }
    }
}
