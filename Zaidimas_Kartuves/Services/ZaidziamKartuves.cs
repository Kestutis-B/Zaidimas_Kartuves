using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class ZaidziamKartuves
    {
        static void zaidziamKartuves(List<string> likeZodziai, string tema)
        {
            string spejamasZodis = string.Empty;
            int bandymai = 0;
            if (likeZodziai.Count > 0)
            {
                spejamasZodis = ZodzioAtrinkimas(likeZodziai); // parenka dar nespeta zodi
                spetiZodziai.Add(spejamasZodis); // atrinkta zodi ikelia i spetu zodziu sarasa
                Console.WriteLine(kartuves[0]);
                do
                {
                    SpejamoZodzioIsvedimas(spejamasZodis); // konsoleje parodomas zodis, kuri reikia atspeti
                    Console.WriteLine($"Jau bandete speti sias raides: {string.Join(" ", spetosRaides)}"); // parodomos raides, kurios jau megintos speti
                    spetosRaides.Add(zodzioArRaidesSpejimas(spejamasZodis).ToUpper()); // spetas raides pridedam i spetu raidziu sarasa
                    bandymai = bandymai + SpejamRaide(spetosRaides[spetosRaides.Count - 1], spejamasZodis); //jei atspeja raide, ji iskeliama vietoj "_", jei ne, bandymai mazeja
                    Console.WriteLine(kartuves[bandymai]);
                } while (bandymai < 7);
                if (bandymai == 7)
                {
                    Console.WriteLine($"Labai gaila, bet pralaimejote... :( , teisingas zodis buvo {spejamasZodis}");
                    BandysiteDarZaisti();
                }
            }
            else
            {
                Console.WriteLine($"Suzaidet visus temos {tema} zodzius, prasom pasirinkti kita tema :) ");
                Kartuves();
            }
        }

        private static void BandysiteDarZaisti()
        {
            throw new NotImplementedException();
        }

        private static void SpejamoZodzioIsvedimas(string spejamasZodis)
        {
            throw new NotImplementedException();
        }
    }
}
