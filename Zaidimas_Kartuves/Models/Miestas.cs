﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Models
{
    public class Miestas
    {
        [Key]
        public int MiestasId { get; set; }
        public string Pavadinimas { get; set; }
        public int SpetaKartų { get; set; }
        public int AtspetaKartų { get; set; }

    }
}