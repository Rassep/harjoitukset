using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo = new Ajoneuvo();
            ajoneuvo.nimi = "Ford";
            ajoneuvo.nopeus = 150;
            ajoneuvo.renkaat = 4;

            ajoneuvo.TulostaData();
            string strAjoneuvo = ajoneuvo.ToString();
            Console.WriteLine(string.Format("strAjoneuvo: {0}", strAjoneuvo));
        }
    }
}
