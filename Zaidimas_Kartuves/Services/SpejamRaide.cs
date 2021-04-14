using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class SpejamRaide
    {
        static int spejamRaide(string spejimas, string spejamasZodis)
        {
            if (spejamasZodis.ToUpper().Contains(spejimas.ToUpper()))
            {
                SpejamoZodzioIsvedimas(spejamasZodis);
                return 0;
            }
            else
            {
                Console.WriteLine($"Raides {spejimas} spejamam zodyje nera... :( ");
                SpejamoZodzioIsvedimas(spejamasZodis);
                return 1;
            }
        }

        private static void SpejamoZodzioIsvedimas(string spejamasZodis)
        {
            throw new NotImplementedException();
        }
    }
}
