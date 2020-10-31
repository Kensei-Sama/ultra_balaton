using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UltraBalaton
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

            Console.WriteLine($"3. feladat: Egyéni indulók: {versenylista.Count} fő");


        }
    }
}