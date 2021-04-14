using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class SpejamoZodzioIsvedimas
    {
        static void spejamoZodzioIsvedimas(string spejamasZodis)
        {
            Console.WriteLine($"Spekite zodi is {spejamasZodis.Length} raidziu ");
            Console.Write("( ");
            int pabandytosRaides = 0; // susikuriam kintamaji, kuris skaiciuoja bandytas raides
            foreach (var raide in spejamasZodis)
            //for (int i = 0; i < spejamasZodis.Length; i++)
            {
                if (spetosRaides.Contains(raide.ToString().ToUpper()))
                {
                    Console.Write($"{raide}");
                    pabandytosRaides += 1;
                }
                Console.Write(" _");
            }
            Console.Write(" )");
            if (spejamasZodis.Length == pabandytosRaides)
            {
                Console.WriteLine("Sveikiname, atspejote visas raides ir laimejote :) ");
                BandysiteDarZaisti();
            }

            Console.WriteLine();
        }
    }
}
