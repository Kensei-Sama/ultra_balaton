using System;
using System.Collections.Generic;
using System.Text;

namespace ult_bal_final
{
    class Versenyzők
    {
        //Versenyzo;Rajtszam;Kategoria;Versenyido;TavSzazalek
        string versenyzonev;
        string rajtszam;
        string kategoria;
        int ora;
        int perc;
        int masodperc;
        int tavszazalek;
        string[] adat;
        string[] seged; 

        public Versenyzők(string y)
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

        public string Versenyzonev { get => versenyzonev; set => versenyzonev = value; }
        public string Rajtszam { get => rajtszam; set => rajtszam = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }
        public int Masodperc { get => masodperc; set => masodperc = value; }
        public int Tavszazalek { get => tavszazalek; set => tavszazalek = value; }
    }
}
