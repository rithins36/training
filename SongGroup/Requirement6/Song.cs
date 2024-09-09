using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement6
{
    public class Song
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

        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _dateDownloaded = dateDownloaded;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
        }

        public static Dictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            var typeCount = new Dictionary<string, int>();

            foreach (var song in list)
            {
                if (typeCount.ContainsKey(song.SongType))
                {
                    typeCount[song.SongType]++;
                }
                else
                {
                    typeCount[song.SongType] = 1;
                }
            }

            return typeCount;
        }

        public static string PredictState(Dictionary<string, int> perTypeCount)
        {
            int maxCount = 0;
            string state = "neutral";

            foreach (var kvp in perTypeCount)
            {
                if (kvp.Key == "Emotional" && kvp.Value > maxCount)
                {
                    state = "depressed";
                    maxCount = kvp.Value;
                }
                else if (kvp.Key == "Celebration" && kvp.Value > maxCount)
                {
                    state = "happy";
                    maxCount = kvp.Value;
                }
                else if (kvp.Key == "Motivational" && kvp.Value > maxCount)
                {
                    state = "energetic";
                    maxCount = kvp.Value;
                }
            }

            return state;
        }
    }
}
