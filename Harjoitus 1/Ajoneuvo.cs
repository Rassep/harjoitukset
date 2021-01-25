using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    class Ajoneuvo
    {
        public string nimi { get; set; }
        
        public int nopeus { get; set; }
        public int renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine(ToString());
        }

        
        override public string ToString()
        {
            return string.Format("Nimi: {0}, Nopeus: {1}, Renkaat: {2}", nimi, nopeus.ToString(), renkaat.ToString());
        }
    }
}
