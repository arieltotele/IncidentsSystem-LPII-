using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{

    public class Sla:BaseEntity {

     public string Descripcion { get; set; }

     [Required]
     public int CantidadHoras { get; set; }

     public int? Creadopor { get; set; }

     public int? Modificadopor { get; set; }

    }
}
