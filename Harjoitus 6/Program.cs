using System;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin gerbiili = new Gerbiili();
            Eläin marsu = new Marsu();

            gerbiili.Ikä = 3;
            marsu.Ikä = 2;
            gerbiili.puhu();
            marsu.puhu();

            Console.WriteLine(marsu.Laji + " " + marsu.Ikä);
            Console.WriteLine(gerbiili.Laji + " " + gerbiili.Ikä);
            
            Eläin.kuinkaMonta();
        }
    }
}
