using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{

    public class Prioridad:BaseEntity {

        public int SladId { get; set; }

        public Sla Sla { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        public int? Creadopor { get; set; }

        public int? Modificadopor { get; set; }

    }
}
