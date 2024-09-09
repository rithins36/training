namespace Requirement2
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
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _noOfDownloads = noOfDownloads;
            _dateDownload = dateDownload;
        }
        public override string ToString()
        {
            return $"{_name,-15}{_artist,-15}{_songType,-15}{_rating,-15:F1}{_noOfDownloads,-15}{_dateDownload:dd-MM-yyyy}";
        }
        public static Song CreateSong(string songDetails)
        {
            string[] details = songDetails.Split(',');
            return new Song(details[0].Trim(), details[1].Trim(), details[2].Trim(), double.Parse(details[3].Trim()), int.Parse(details[4].Trim()), DateTime.Parse(details[5].Trim()));
        }
    }
    class Playlist
    {
        private string _name;
        private List<Song> _songlist;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Song> SongList
        {
            get { return _songlist; }
            set { _songlist = value; }
        }
        public Playlist(string name)
        {
            _name = name;
            _songlist = new List<Song>();
        }
        public void AddSong(Song song)
        {
            _songlist.Add(song);
        }
        public bool RemoveSong(string name)
        {
            Song songRemove=_songlist.Find(song=>song.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (songRemove != null)
            {
                _songlist.Remove(songRemove);
                return true;
            }
            return false;
        }
        public void DisplaySongs()
        {
            if (_songlist.Count == 0) {
                Console.WriteLine("No song to show");
            }
            else
            {
                Console.WriteLine("Name   Artist  SongType   Rating  NoOfDownload  DateDownloaded");
                foreach (Song song in _songlist)
                {
                    Console.WriteLine(song.ToString());
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the PLaylist Name: ");
            string playlistName=Console.ReadLine();
            Playlist myPlaylist = new Playlist(playlistName);
            while (true)
            {
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Remove Song");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Your choice");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Number of Songs");
                        int noOfSongs = int.Parse(Console.ReadLine());
                        for (int i=0; i<noOfSongs; i++)
                        {
                            Console.WriteLine($"Enter song {i + 1} details: ");
                            string songDetail=Console.ReadLine();
                            Song newSong=Song.CreateSong(songDetail);
                            myPlaylist.AddSong(newSong);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the song to be deleted");
                        string songName=Console.ReadLine();
                        bool isDeleted=myPlaylist.RemoveSong(songName);
                        if (isDeleted)
                        {
                            Console.WriteLine("Song Successfully Deleted");
                        }
                        else
                        {
                            Console.WriteLine("Song not found in Playlist");
                        }
                        break;
                    case 3:
                        myPlaylist.DisplaySongs();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Wrong choice..!");
                        break;
                }
            }
        }
    }
}
