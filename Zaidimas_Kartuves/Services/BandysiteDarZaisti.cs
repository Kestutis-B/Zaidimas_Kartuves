using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class BandysiteDarZaisti
    {
        static void bandysiteDarZaisti()
        {
            Console.WriteLine("Bandysite dar zaisti? :) ");
            Console.WriteLine("Spauskite 't' jei norite zaisti, 'n' jei nenorite zaisti");
            int x = 0;
            while (x != 1)
            {
                string BandymasDar = Console.ReadKey().KeyChar.ToString();
                if (BandymasDar.Equals("t", StringComparison.OrdinalIgnoreCase)) // StringComparison.OrdinalIgnoreCase reikalingas tam,
                                                                                 // kad programa nuskaitytu raide, nepriklausomai didzioji ar mazoji bus ivesta
                {
                    x = 1;
                    spetosRaides.Clear(); // jei bando dar zaisti, istrinamos spetos raides, kad vel jas galima butu speti
                    Kartuves();
                }
                else if (BandymasDar.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    System.Environment.Exit(1); // jei iveda n raide, sistema iseina is zaidimo
                }
                else
                {
                    Console.WriteLine("\nIvedet neteisinga simboli, iveskit 't' arba 'n'");
                }
            }
        }
    }
}
