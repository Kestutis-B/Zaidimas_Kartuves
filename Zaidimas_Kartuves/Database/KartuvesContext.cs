using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Kartuves.Models;


namespace Zaidimas_Kartuves.Database
{
    public class KartuvesContext :DbContext
    {
        public DbSet<Vardas> Vardas { get; set; }
        public DbSet<Miestas> Miestas { get; set; }
        public DbSet<Valstybe> Valstybe { get; set; }
        public DbSet<Paukstis> Paukstis { get; set; }

        
    }
}
