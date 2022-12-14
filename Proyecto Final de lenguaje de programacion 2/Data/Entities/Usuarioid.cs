using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    [Table("usuarioId")]

    public class Usuarioid
    {
        [Key]
        public int usuarioId { get; set; }

        public int puestoId { get; set; }
        public Puesto Puesto { get; set; }

        public string Nombre { get; set; }

        public string apellido { get; set; }

        public string Cedula { get; set; }

        public string Correo { get; set; }

        public string telefono { get; set; }

        public DateTime FechaNacimineto { get; set; }

        public string nombreusuario { get; set; }

        public string contraseña { get; set; }

        public string Estatus { get; set; }

        public  byte Borrado { get; set; }

       public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset FechaModificacion { get; set; }

        public int creadopor { get; set; }

        public int Modificadopo { get; set; }
    }
}
