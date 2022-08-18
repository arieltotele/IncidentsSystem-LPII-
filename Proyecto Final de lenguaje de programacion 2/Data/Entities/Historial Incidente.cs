﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Final_de_lenguaje_de_programacion_2.Data.Entities
{

    public class Historial_Incidente : BaseEntity
    {

        public int IncidenteId { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string Comentario { get; set; }

        public int? Creadopor { get; set; }

        public int? Modificadopor { get; set; }
    }
}