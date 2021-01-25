using System;

namespace Harjoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi album = new Albumi("Traphouse kari ", "Neliveto ruoska", "Hip-Hop/Rap", 20);

            album.addSong(new Kappale("Kermaperse", "2.38"));
            album.addSong(new Kappale("Ikoni", "4:01"));
            album.addSong(new Kappale("Moottoriöljy", "2.41"));
            album.addSong(new Kappale("Nuutin rahnat", "2:03"));
            album.addSong(new Kappale("Kiltsu", "3:27"));
            album.addSong(new Kappale("Pönttöpää", "4:10"));
            album.addSong(new Kappale("Kinkin paku ", "3:10"));

            album.printToConsole();
        }
    }
}
