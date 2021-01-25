using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    public class Eläin
    {
        public virtual int Ikä { get; set; }
        public virtual string Laji { get; set; }

        public static int instances;

        public Eläin()
        {
            instances++;
        }

        public static void kuinkaMonta()
        {
            Console.WriteLine("Eläimiä on {0} kappaletta", instances);
        }

        public virtual void puhu()
        {
            Console.WriteLine("Eläin puhuu");
        }
    }
}
