using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    [Table("Departamento")]

    public class Departamento
    {
        public int Departamentoid { get; set; }

        public string Nombre { get; set; }

        public string Estatus { get; set; }

        public byte Borrado { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset FechaModificacion { get; set; }

        public int Creadopor { get; set; }

        public int Modificadopor { get; set; } 

        public List<Puesto> puestos { get; set; }
    }
}
