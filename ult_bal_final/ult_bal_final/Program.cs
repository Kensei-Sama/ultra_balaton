using System;
using System.Collections.Generic;
using System.IO;

namespace ult_bal_final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzők> versenylista = new List<Versenyzők>();
            string[] adatok = File.ReadAllLines("ub2017egyeni.txt");
            for (int i = 1; i < adatok.Length; i++)
            {
                versenylista.Add(new Versenyzők(adatok[i]));
            }

            //3. feladat
            Console.WriteLine($"3. Feladat: Egyéni indulók: {versenylista.Count} fő");

            //4. feladat
            int nok = 0;
            for (int i = 0; i < versenylista.Count; i++)
            {
                if (versenylista[i].Kategoria == "Női" && versenylista[i].Tavszazalek == 100)
                {
                    nok++;
                }
            }
            Console.WriteLine($"4. Feladat: Célba érkező női sportolók: {nok} fő");

            //5. feladat
            string nev;
            int seged = 0;
            Console.WriteLine("Adja meg a sportoló nevét: ");
            nev = Console.ReadLine();
            while (seged < )
            {

            }

            Console.ReadKey();
        }
    }
}
