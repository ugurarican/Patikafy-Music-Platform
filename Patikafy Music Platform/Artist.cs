using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy_Music_Platform
{
    internal class Artist
    {
        public string ArtistNameSurname { get; set; }
        public string MusicGenre { get; set; }
        public int ReleaseYear { get; set; }
        public int SalesAmount { get; set; }

        public Artist(string name, string genre, int year, int sales)
        {
            ArtistNameSurname = name;
            MusicGenre = genre;
            ReleaseYear = year;
            SalesAmount = sales;
        }
        public override string ToString()
        {
            return $"{ArtistNameSurname} - {MusicGenre} - {ReleaseYear} - {SalesAmount} sales";

        }
    }
}

