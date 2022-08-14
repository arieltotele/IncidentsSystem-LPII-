using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    public class BaseEntity{

        public int Id { get; set; }

        public string Estatus { get; set; }

        public byte Borrado { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset? FechaModificacion { get; set; }
    }
}
