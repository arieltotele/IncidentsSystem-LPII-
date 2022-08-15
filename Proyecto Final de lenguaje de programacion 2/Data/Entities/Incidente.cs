using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    public class Incidente : BaseEntity {

        public int UsuarioReportadoId { get; set; }

        public int UsuarioAsignadoId { get; set; }

        public int PrioridadId { get; set; }
        public Prioridad prioridad { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento departamento { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength]
        [Column(TypeName = "varchar")]
        public string Descripcion { get; set; }

        public DateTimeOffset FechaCierre { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string ComentarioCierre { get; set; }

        public int Creadopor { get; set; }

        public int Modificadopor { get; set; }

        public Usuarioid usuario { get; set; }
    }
}
