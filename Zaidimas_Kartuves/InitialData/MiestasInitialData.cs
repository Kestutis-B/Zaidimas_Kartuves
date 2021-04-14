using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Kartuves.Models;

namespace Zaidimas_Kartuves.InitialData
{
    public static class MiestasInitialData
    {
        public static Miestas[] DataSeed => new Miestas[]
        {
            new Miestas
            {
                MiestasId = 1,
                Pavadinimas = "Klaipeda",
            },
            new Miestas
            {
                MiestasId = 2,
                Pavadinimas = "Pakruojis",
            },
            new Miestas
            {
                MiestasId = 3,
                Pavadinimas = "Palanga",
            },
            new Miestas
            {
                MiestasId = 4,
                Pavadinimas = "Vilkaviskis",
            },
            new Miestas
            {
                MiestasId = 5,
                Pavadinimas = "Panevezys",
            },
            new Miestas
            {
                MiestasId = 6,
                Pavadinimas = "Jurbarkas",
            },
            new Miestas
            {
                MiestasId = 7,
                Pavadinimas = "Taurage",
            },
            new Miestas
            {
                MiestasId = 8,
                Pavadinimas = "Ignalina",
            },
            new Miestas
            {
                MiestasId = 9,
                Pavadinimas = "Visaginas",
            },
            new Miestas
            {
                MiestasId = 10,
                Pavadinimas = "Kelme",
            },

        };

    }
}
