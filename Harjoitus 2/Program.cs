using System;
using System.Collections.Generic;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Opiskelija> opiskelijat = new List<Opiskelija>();

            Opiskelija opiskelija1 = new Opiskelija("Pertti", "1", 10);
            opiskelijat.Add(opiskelija1);

            Opiskelija opiskelija2 = new Opiskelija("Jussi", "2", 35);
            opiskelijat.Add(opiskelija2);

            Opiskelija opiskelija3 = new Opiskelija("Niklas", "3", 5);
            opiskelijat.Add(opiskelija3);

            opiskelija1.muokkaaOpintopisteitä(15);
            opiskelija2.muokkaaOpintopisteitä(30);
            opiskelija3.muokkaaOpintopisteitä(10);

            foreach (Opiskelija opiskelija in opiskelijat)
            {
                opiskelija.tulostaData();
            }
        }
    }
}
