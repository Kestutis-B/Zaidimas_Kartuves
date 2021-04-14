using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Kartuves.Models;

namespace Zaidimas_Kartuves.InitialData
{
    public static class PaukstisInitialData
    {
        public static Paukstis[] DataSeed => new Paukstis[]
        {
            new Paukstis
            {
                PaukstisId = 1,
                Pavadinimas = "Erelis",
            },
            new Paukstis
            {
                PaukstisId = 2,
                Pavadinimas = "Strutis",
            },
            new Paukstis
            {
                PaukstisId = 3,
                Pavadinimas = "Fazanas",
            },
            new Paukstis
            {
                PaukstisId = 4,
                Pavadinimas = "Tetervinas",
            },
            new Paukstis
            {
                PaukstisId = 5,
                Pavadinimas = "Kikilis",
            },
            new Paukstis
            {
                PaukstisId = 6,
                Pavadinimas = "Kregzde",
            },
            new Paukstis
            {
                PaukstisId = 7,
                Pavadinimas = "Kolibris",
            },
            new Paukstis
            {
                PaukstisId = 8,
                Pavadinimas = "Nykstukas",
            },
            new Paukstis
            {
                PaukstisId = 9,
                Pavadinimas = "Ciurlys",
            },
            new Paukstis
            {
                PaukstisId = 10,
                Pavadinimas = "Strazdas",
            },
        };
    }
}
