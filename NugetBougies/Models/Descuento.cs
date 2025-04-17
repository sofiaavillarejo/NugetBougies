﻿using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBougies.Models
{
    [Table("Descuentos")]

    public class Descuento
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Valor")]
        public int Valor { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }
    }
}
