using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    public class BaseEntity{

        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        public string Estatus { get; set; }

        public byte Borrado { get; set; }

        public DateTimeOffset FechaRegistro { get; set; }

        public DateTimeOffset? FechaModificacion { get; set; }
    }
}
