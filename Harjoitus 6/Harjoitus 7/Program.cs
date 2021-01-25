using System;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            while (true)
            {
                Console.Write("Syötä kerros (1-6) > ");
                string input = Console.ReadLine();

                int iInput = 0;
                try
                {
                    iInput = int.Parse(input);
                } catch
                {
                    Console.WriteLine("Kirjoittamasi merkki ei ole numero!");
                    continue;
                }

                hissi.Kerros = iInput;
            }
        }
    }
}
