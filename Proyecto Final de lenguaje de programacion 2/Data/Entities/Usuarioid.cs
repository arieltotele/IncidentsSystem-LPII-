using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{

    public class Usuarioid:BaseEntity {

        public int puestoId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [Required]
        [MaxLength(11)]
        [Column(TypeName = "varchar")]
        public string Cedula { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Correo { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar")]
        public string Telefono { get; set; }

        public DateTime FechaNacimineto { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string nombreusuario { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string contraseña { get; set; }

        public int? Creadopor { get; set; }

        public int? Modificadopor { get; set; }
    }
}
