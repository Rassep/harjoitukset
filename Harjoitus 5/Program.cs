using System;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("1+1: {0}\n1-1: {1}\n10*2: {2}\n10/2: {3}", Laskin.summa(1, 1), Laskin.erotus(1, 1), Laskin.kertolasku(10, 2), Laskin.jako(10, 2)));
        }
    }
}
