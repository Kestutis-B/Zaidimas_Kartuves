using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Kartuves.Models;

namespace Zaidimas_Kartuves.InitialData
{
    public static class ValstybeInitialData
    {
        public static Valstybe[] DataSeed => new Valstybe[]
        {
            new Valstybe
            {
                ValstybeId = 1,
                Pavadinimas = "Portugalija",
            },
            new Valstybe
            {
                ValstybeId = 2,
                Pavadinimas = "Venesuela",
            },
            new Valstybe
            {
                ValstybeId = 3,
                Pavadinimas = "Egiptas",
            },
            new Valstybe
            {
                ValstybeId = 4,
                Pavadinimas = "Turkija",
            },
            new Valstybe
            {
                ValstybeId = 5,
                Pavadinimas = "Pakistanas",
            },
            new Valstybe
            {
                ValstybeId = 6,
                Pavadinimas = "Japonija",
            },
            new Valstybe
            {
                ValstybeId = 7,
                Pavadinimas = "Argentina",
            },
            new Valstybe
            {
                ValstybeId = 8,
                Pavadinimas = "Ukraina",
            },
            new Valstybe
            {
                ValstybeId = 9,
                Pavadinimas = "Australija",
            },
            new Valstybe
            {
                ValstybeId = 10,
                Pavadinimas = "Armenija",
            },

        };
    }
}
