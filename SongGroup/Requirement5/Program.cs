namespace Requirement5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int numberOfSongs = int.Parse(Console.ReadLine());
                ;
            for (int i = 0; i < numberOfSongs; i++)
            {
                Console.WriteLine($"Enter details for song {i + 1} (format: name,artist,songType,dateDownloaded,rating,numberOfDownloads):");
                string[] songDetails = Console.ReadLine().Split(',');

                if (songDetails.Length != 6 ||
                    !DateTime.TryParse(songDetails[3], out DateTime dateDownloaded) ||
                    !double.TryParse(songDetails[4], out double rating) ||
                    !int.TryParse(songDetails[5], out int numberOfDownloads))
                {
                    Console.WriteLine("Invalid input format.");
                    i--;
                    continue;
                }

                Song song = new Song(
                    songDetails[0],
                    songDetails[1],
                    songDetails[2],
                    dateDownloaded,
                    rating,
                    numberOfDownloads);

                songs.Add(song);
            }

            SortedDictionary<string, int> typeCount = Song.CalculateTypeCount(songs);

            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach (var kvp in typeCount)
            {
                Console.WriteLine("{0,15} {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
