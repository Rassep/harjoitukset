using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Marsu : Eläin
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
                Console.WriteLine("Marsun ikä on nyt {0}", ikä);
            }
        }

        public override string Laji
        {
            get
            {
                return "Marsu";
            }
        }

        public override void puhu()
        {
            Console.WriteLine("Marsu puhuu");
        }
    }
}
