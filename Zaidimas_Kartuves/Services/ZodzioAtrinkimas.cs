using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class ZodzioAtrinkimas
    {
        static string zodzioAtrinkimas(List<string> zodziuListas)

        {

            Random rnd = new Random();
            int listoNarioNumeris = rnd.Next(0, zodziuListas.Count);
            zodziuListas.RemoveAt(listoNarioNumeris);
            return zodziuListas[listoNarioNumeris];
        }
    }
}
