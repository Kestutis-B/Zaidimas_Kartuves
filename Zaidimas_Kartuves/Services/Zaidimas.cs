using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kartuves.Services
{
    public class Zaidimas
    {
        static readonly List<string> vardai = new List<string> { "Deividas", "Algirdas", "Justinas", "Nerijus", "Egidijus", "Tatjana", "Margarita", "Brigita", "Leonarda", "Barbora" };
        static readonly List<string> miestai = new List<string> { "Klaipeda", "Pakruojis", "Palanga", "Vilkaviskis", "Panevezys", "Jurbarkas", "Taurage", "Ignalina", "Visaginas", "Kelme" };
        static readonly List<string> valstybes = new List<string> { "Portugalija", "Venesuela", "Egiptas", "Turkija", "Pakistanas", "Japonija", "Argentina", "Ukraina", "Australija", "Armenija" };
        static readonly List<string> pauksciai = new List<string> { "Erelis", "Strutis", "Fazanas", "Tetervinas", "Kikilis", "Kregzde", "Kolibris", "Nykstukas", "Ciurlys", "Strazdas" };
        static readonly List<string> spetosRaides = new List<string>();
        static readonly List<string> spetiZodziai = new List<string>();

        static readonly Dictionary<int, string> kartuves = new Dictionary<int, string>
            {
                {0, " -------------|\n|\n|\n|\n|\n|\n|\n|\n________" },
                {1, " -------------|\n|             o\n|\n|\n|\n|\n|\n|\n________" },
                {2, " -------------|\n|             o\n|             |\n|\n|\n|\n|\n|\n________" },
                {3, " -------------|\n|             o\n|             |\n|             O\n|\n|\n|\n|\n________" },
                {4, " -------------|\n|             o\n|            \\|\n|             O\n|\n|\n|\n|\n________" },
                {5, " -------------|\n|             o\n|            \\|/\n|             O\n|\n|\n|\n|\n________" },
                {6, " -------------|\n|             o\n|            \\|/\n|             O\n|            /\n|\n|\n|\n________" },
                {7, " -------------|\n|             o\n|            \\|/\n|             O\n|            / \\\n|\n|\n|\n________" }
            };



        static void Main(string[] args)
        {

            Kartuves();


            Console.WriteLine();
            Console.WriteLine("---Press any key to continue---");
            Console.ReadKey();
        }


        static void Kartuves()
        {

            Console.WriteLine("Zaidimas ---Kartuves---");
            Console.WriteLine($"Suzaisti zodziai yra sie: {string.Join(" ", spetiZodziai)}"); // konsole isveda jau spetus zodzius, jei tokiu yra
            string tema = TemosPasirinkimas(); // metoda nurodom kaip string kintamaji

            if (tema == "vardai")
            {
                ZaidziamKartuves(vardai, tema);
            }
            else if (tema == "miestai")
            {
                ZaidziamKartuves(miestai, tema);

            }
            else if (tema == "valstybes")
            {
                ZaidziamKartuves(valstybes, tema);

            }
            else if (tema == "pauksciai") // jei tik else, tai braukia raudonai
            {
                ZaidziamKartuves(pauksciai, tema);

            }
            Console.WriteLine();
        }

        static void ZaidziamKartuves(List<string> likeZodziai, string tema)
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


        static int SpejamRaide(string spejimas, string spejamasZodis)
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

        static void SpejamoZodzioIsvedimas(string spejamasZodis)
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


        static void BandysiteDarZaisti()
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


        static string TemosPasirinkimas()

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
                        BandysiteDarZaisti();
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


        static string ZodzioAtrinkimas(List<string> zodziuListas)

        {

            Random rnd = new Random();
            int listoNarioNumeris = rnd.Next(0, zodziuListas.Count);
            zodziuListas.RemoveAt(listoNarioNumeris);
            return zodziuListas[listoNarioNumeris];
        }


        static bool ArRaides(string spejimas)
        {
            foreach (char raide in spejimas)
            {
                if (!Char.IsLetter(raide))
                    return false;
            }
            return true;
        }
    }
}
