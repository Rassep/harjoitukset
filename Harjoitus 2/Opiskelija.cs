using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        private string nimi { get; set; }
        private string opiskelijaID { get; set; }

        private int opintoPisteet { get; set; }

        public Opiskelija(string _nimi, string _opiskelijaID, int _opintoPisteet)
        {
            nimi = _nimi;
            opiskelijaID = _opiskelijaID;
            opintoPisteet = _opintoPisteet;
        }

        public void tulostaData()
        {
            Console.WriteLine(string.Format("Opiskelija {0}, Opiskelija ID: {1}, Opintopisteet: {2}", nimi, opiskelijaID, opintoPisteet.ToString()));
        }

        public void muokkaaOpintopisteitä(int _opintoPisteet)
        {
            opintoPisteet = _opintoPisteet;
        }
    }
}
