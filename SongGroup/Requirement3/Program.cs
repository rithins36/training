namespace Requirement3
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Songs:");
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter Song {i + 1} details: ");
            string[] songDetails = Console.ReadLine().Split(',');
            Song song = new Song(songDetails[0], songDetails[1], songDetails[2], double.Parse(songDetails[3]),
                int.Parse(songDetails[4]), DateTime.ParseExact(songDetails[5], "dd-MM-yyyy", null));
            songs.Add(song);
        }

        SongBO songBO = new SongBO();
        Console.WriteLine("Enter a search type:\n1. Song Type\n2. Date of Download\n3. Rating");
        int choice = int.Parse(Console.ReadLine());

        List<Song> result = null;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the type:");
                string type = Console.ReadLine();
                result = songBO.FindSong(songs, type);
                break;

            case 2:
                Console.WriteLine("Enter the date (dd-MM-yyyy):");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                result = songBO.FindSong(songs, date);
                break;

            case 3:
                Console.WriteLine("Enter the rating:");
                double rating = double.Parse(Console.ReadLine());
                result = songBO.FindSong(songs, rating);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        if (result != null && result.Count > 0)
        {
            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-10} {4,-15} {5,-15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
            foreach (var song in result)
            {
                Console.WriteLine(song.ToString());
            }
        }
        else
        {
            Console.WriteLine("No songs found.");
        }
    }
}
}
