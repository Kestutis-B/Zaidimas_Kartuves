using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class ZodzioArRaidesSpejimas
    {
        static string zodzioArRaidesSpejimas(string spejamasZodis)
        {
            string spejimas = string.Empty;
            Console.WriteLine("Spekite visa zodi arba po viena raide");

            int x = 0;
            while (x != 1)
            {
                spejimas = Console.ReadLine(); //nuskaito zaidejo ivesta simboli
                if (!ArRaides(spejimas)) // jei ivestas simbolis ne raide, tai parasoma konsoleje
                {
                    Console.WriteLine("Ivedet neteisinga simboli. Iveskite visa zodi arba raide");
                }
                else if (spejimas.Length > 1) // jei iveda daugiau kaip 1 simboli, reiskia speja zodi
                {
                    if (spejimas.Length != spejamasZodis.Length)
                    {
                        Console.WriteLine($"Spejote zodi is {spejimas.Length} raidziu, o zodis susideda is {spejamasZodis.Length} raidziu");
                    }
                    else if (spejimas.ToUpper() == spejamasZodis.ToUpper()) //raides verciamos i didziasias, kad spejimas ir uzduodamas zodis sutaptu
                    {
                        Console.WriteLine("Sveikiname, atspejote zodi ir laimejote zaidima :) ");
                    }
                    else
                    {
                        Console.WriteLine("Labai gaila, bet neatspejot zodzio ir pralaimejot");
                        Console.WriteLine(kartuves[7]);
                        BandysiteDarZaisti();
                    }
                }
                else x = 1;
            }
            return spejimas;

        }
    }
}
