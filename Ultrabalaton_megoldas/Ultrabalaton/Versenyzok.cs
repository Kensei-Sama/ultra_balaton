using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    class Versenyzok
    {
        public double idoOraban;
        string vers_nev;
        string rajtszam;
        string kategoria;
        int ora;
        int perc;
        int masodperc;
        int tavszazalek;
        string[] adat;
        string[] seged;
        public Versenyzok(string y)
        {
            adat = y.Split(';');
            Versenyzonev = adat[0];
            Rajtszam = adat[1];
            Kategoria = adat[2];
            seged = adat[3].Split(':');
            Ora = int.Parse(seged[0]);
            Perc = int.Parse(seged[1]);
            Masodperc = int.Parse(seged[2]);
            Tavszazalek = Convert.ToInt32(adat[4]);
        }

        public string Versenyzonev { get => vers_nev; set => vers_nev = value; }
        public string Rajtszam { get => rajtszam; set => rajtszam = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public int Tavszazalek { get => tavszazalek; set => tavszazalek = value; }
        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }
        public int Masodperc { get => masodperc; set => masodperc = value; }
    }
}