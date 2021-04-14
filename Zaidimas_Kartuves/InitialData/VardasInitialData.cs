using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Kartuves.Models;


namespace Zaidimas_Kartuves.InitialData
{
    public static class VardasInitialData
    {
        public static Vardas[] DataSeed => new Vardas[]
        {
            new Vardas
            {
                VardasId = 1,
                Pavadinimas = "Deividas",
            },
            new Vardas
            {
                VardasId = 2,
                Pavadinimas = "Algirdas",
            },
            new Vardas
            {
                VardasId = 3,
                Pavadinimas = "Justinas",
            },
            new Vardas
            {
                VardasId = 4,
                Pavadinimas = "Nerijus",
            },
            new Vardas
            {
                VardasId = 5,
                Pavadinimas = "Egidijus",
            },
            new Vardas
            {
                VardasId = 6,
                Pavadinimas = "Tatjana",
            },
            new Vardas
            {
                VardasId = 7,
                Pavadinimas = "Margarita",
            },
            new Vardas
            {
                VardasId = 8,
                Pavadinimas = "Brigita",
            },
            new Vardas
            {
                VardasId = 9,
                Pavadinimas = "Leonarda",
            },
            new Vardas
            {
                VardasId = 10,
                Pavadinimas = "Barbora",
            },

        };
    }
}
