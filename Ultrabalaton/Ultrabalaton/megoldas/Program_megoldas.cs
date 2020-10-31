using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ultrabalaton
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzok> versenylista = new List<Versenyzok>();
            string[] adatok = File.ReadAllLines("ub2017egyeni.txt");
            for (int i = 1; i < adatok.Length; i++)
            {
                versenylista.Add(new Versenyzok(adatok[i]));
            }

            //3.Feladat
            Console.WriteLine($"3. Feladat: Egyéni indulók: {versenylista.Count} fő");

            //4.Feladat
            int nok = 0;
            for (int i = 0; i < versenylista.Count; i++)
            {
                if ((versenylista[i].Kategoria == "Női" && versenylista[i].Tavszazalek == 100))
                {
                    nok++;
                }
            }
            Console.WriteLine($"4. Feladat: Célba érkező női sportolók: {nok} fő");

            //5.Feladat
            string nev;
            int seged = 0;
            Console.Write("5.Feladat: Kérem a sportoló nevét: ");
            nev = Console.ReadLine();
            while (seged < versenylista.Count && !(versenylista[seged].Versenyzonev == nev))
            {
                seged++;
            }
            if (seged < versenylista.Count)
            {
                Console.WriteLine($"Indult egyéniben a sportoló? Igen");
                if (versenylista[seged].Tavszazalek == 100)
                {
                    Console.WriteLine($"Teljesítette a teljes távot? Igen");
                }
                else
                {
                    Console.WriteLine($"Teljesítette a teljes távot? Nem");
                }
            }
            else
            {
                Console.WriteLine($"Indult egyéniben a sportoló? Nem");
            }

            //6.Feladat
            for (int i = 0; i < versenylista.Count; i++)
            {
                versenylista[i].idoOraban = HatodikFeladat(versenylista[i].Ora, versenylista[i].Perc, versenylista[i].Masodperc);
            }
            //7.Feladat
            double orak = 0;
            int egyezes = 0;
            for (int i = 0; i < versenylista.Count; i++)
            {
                if ((versenylista[i].Kategoria == "Ferfi" && versenylista[i].Tavszazalek == 100))
                {
                    orak += versenylista[i].idoOraban;
                    egyezes++;
                }
            }
            Console.WriteLine($"7. Feladat: Átlagos idő: {orak / egyezes} óra");

            //8.Feladat
            double noiseged = 100;
            double ferfiseged = 100;
            string noinev = "";
            string ferfinev = "";
            int noivszam = 0;
            int ferfivszam = 0;
            string noiido = "";
            string ferfiido = "";
            for (int i = 0; i < versenylista.Count; i++)
            {
                if ((versenylista[i].Kategoria == "Noi" && versenylista[i].idoOraban < noiseged && versenylista[i].Tavszazalek == 100))
                {
                    noinev = versenylista[i].Versenyzonev;
                    noiseged = versenylista[i].idoOraban;
                    noivszam = Convert.ToInt32(versenylista[i].Rajtszam);
                    noiido = $"{versenylista[i].Ora}:{versenylista[i].Perc}:{versenylista[i].Masodperc}";
                }
                if ((versenylista[i].Kategoria == "Ferfi" && versenylista[i].idoOraban < ferfiseged && versenylista[i].Tavszazalek == 100))
                {
                    ferfinev = versenylista[i].Versenyzonev;
                    ferfiseged = versenylista[i].idoOraban;
                    ferfivszam = Convert.ToInt32(versenylista[i].Rajtszam);
                    ferfiido = $"{versenylista[i].Ora}:{versenylista[i].Perc}:{versenylista[i].Masodperc}";
                }
            }
            Console.WriteLine($"8. Feladat: Verseny győztesei");
            Console.WriteLine($"        Nők: {noinev} ({noivszam}.) - {noiido}");
            Console.WriteLine($"        Férfiak: {ferfinev} ({ferfivszam}.) - {ferfiido}");
            Console.WriteLine();
            Console.ReadLine();
        }
        static double HatodikFeladat(double x, double y, double z)
        {
            double seged = 0;
            double seged2 = y / 60;
            double seged3 = z / 3600;
            seged = (x + seged2 + seged3);
            return seged;
        }
    }
}
