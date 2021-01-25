using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4
{
    class Albumi
    {
        private string artist { get; set; }
        private string name { get; set; }
        private string genre { get; set; }
        private int price { get; set; }

        private List<Kappale> songs;

        public Albumi(string _artist, string _name, string _genre, int _price)
        {
            artist = _artist;
            name = _name;
            genre = _genre;
            price = _price;

            songs = new List<Kappale>();
        }

        public void printToConsole()
        {
            Console.Write(string.Format("Album:\n- Artist: {0}\n- Name: {1}\n- Genre: {2}\n- Price: {3}e\n\n", artist, name, genre, price));

            Console.WriteLine("Songs:");
            foreach (Kappale song in songs)
            {
                Console.WriteLine(string.Format("- {0}", song.ToString()));
            }
        }

        public void addSong(Kappale song)
        {
            songs.Add(song);
        }

        public void removeSong(Kappale song)
        {
            songs.Remove(song);
        }

        public void clearSongs()
        {
            songs.Clear();
        }

        public List<Kappale> getSongs()
        {
            return songs;
        }
    }
}
