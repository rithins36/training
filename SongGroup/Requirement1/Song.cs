using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement1
{
    public class Song 
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _noOfDownloads;
        private DateTime _dateDownload;

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
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int NoOfDownloads
        {
            get { return _noOfDownloads; }
            set { _noOfDownloads = value; }
        }
        public DateTime DateDownload
        {
            get { return _dateDownload; }
            set { _dateDownload = value; }
        }

        public Song(string name, string artist, string songType, double rating, int noOfDownloads, DateTime dateDownload)
        {
            _name= name;
            _artist= artist;
            _songType= songType;
            _rating= rating;
            _noOfDownloads= noOfDownloads;
            _dateDownload= dateDownload;
        }

        public override string ToString()
        {
            return $"Name: {_name}\nArtist: {_artist}\nSong Type: {_songType}\nRating: {_rating:F1}\nNumber of Downloads: {_noOfDownloads}\nDate Downloaded: {_dateDownload}";
        }
        public override bool Equals(object obj)
        {
            Song other = (Song)obj;
            return string.Equals(other._name, _name, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(other._artist, _artist, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(_songType, other._songType, StringComparison.OrdinalIgnoreCase);
        }
    }
}
