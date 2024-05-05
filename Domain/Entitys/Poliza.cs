﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys
{
    public class Poliza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolicaId { get; set; }
        public int PlanId { get; set; }
        public decimal Prima { get; set; }
        public DateTime FechaVencimiento {  get; set; }
        public DateTime FechaInicio { get; set; }

        public int BienAseguradoId { get; set; }
        public BienAsegurado BienAsegurado {  get; set; }

    }
}
