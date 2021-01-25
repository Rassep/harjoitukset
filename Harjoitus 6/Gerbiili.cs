using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Gerbiili : Eläin
    {
        private int ikä;

        public override int Ikä
        {
            get
            {
                return ikä;
            }
            set
            {
                ikä = value;
                Console.WriteLine("Gerbiilin ikä on nyt {0}", ikä);
            }
        }

        public override string Laji
        {
            get
            {
                return "Gerbiili";
            }
        }

        public override void puhu()
        {
            Console.WriteLine("Gerbiili puhuu");
        }
    }
}
