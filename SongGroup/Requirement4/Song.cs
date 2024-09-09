using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public class Song : IComparable<Song>
    {
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime _dateDownloaded;
        private double _rating;
        private int _numberOfDownloads;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }
        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
        }

        public static Song CreateSong(string detail)
        {
            string[] details = detail.Split(',');
            return new Song(details[0], details[1], details[2], double.Parse(details[3]),
                             int.Parse(details[4]), DateTime.ParseExact(details[5], "dd-MM-yyyy", null));
        }
        public int CompareTo(Song other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{_name,-20} {_artist,-15} {_songType,-15} {_rating,-10} {_numberOfDownloads,-15} {_dateDownloaded:dd-MM-yyyy,-15}";
        }
    }
}
