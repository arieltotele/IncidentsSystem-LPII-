using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{
    [Table("Sla")]

    public class Sla:BaseEntity {

     public string Descripcion { get; set; }

     public int CantidadHoras { get; set; }

     public int Creadopor { get; set; }

     public int Modificadopor { get; set; }

     public Usuarioid usuario { get; set; }

    }
}
