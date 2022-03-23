﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElektronikaiAlkatreszRaktar.Models
{
    public class Adatmodel
    {
        public int Id { get; set; }
        [StringLength(60)]
        [Display(Name = "Megnevezés")]
        public string Megnevezes { get; set; }
        [StringLength(60)]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }
        [StringLength(30)]
        [Display(Name = "Típus")]
        public string Tipus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Beszerzési ár")]
        public decimal BeszerzesiAr { get; set; }
    }
}
