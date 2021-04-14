using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public static class TemosPasirinkimas
    {
        static string temosPasirinkimas()

        {

            string[] temosString = { "vardai", "miestai", "valstybes", "pauksciai" };
            Console.WriteLine($"Pasirinkite tema: 1 - vardai; 2 - Lietuvos miestai; 3 - valstybes; 4 - pauksciai");
            int x = 0;
            int skaicius = 0;
            while (x != 1)
            {
                char temosPasirinkimas = Console.ReadKey().KeyChar;
                if (int.TryParse(temosPasirinkimas.ToString(), out skaicius))
                {
                    if (skaicius < 1 && skaicius > 4)
                    {
                        Console.WriteLine($"Pasrinkote neteisinga skaiciu {skaicius}");
                    }
                    else x = 1;
                }
                else Console.WriteLine("Si karta iveskite teisinga skaiciu nuo 1 iki 4");
            }
            Console.WriteLine($"Pasirinkote tema \\*{temosString[skaicius - 1]}\\*");
            return temosString[skaicius - 1];

        }
    }
}
