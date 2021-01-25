using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
{
    class Hissi
    {
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }

            set
            {
                if (value < 1 || value > 6)
                {
                    Console.WriteLine("Error: Virheellinen kerros!");
                } else
                {
                    kerros = value;
                    Console.WriteLine("Hissi on nyt kerroksessa : {0}", kerros);
                }
            }
        }

        public Hissi()
        {
            Kerros = 1;
        }
    }
}
