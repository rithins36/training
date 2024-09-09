namespace Requirement4
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
                Console.WriteLine($"Enter Song {i+1} details: ");
                string songDetails = Console.ReadLine();
                songs.Add(Song.CreateSong(songDetails));
            }

            Console.WriteLine("Enter a type to sort:\n1. Sort by name\n2. Sort by Rating\n3. Sort by Popularity");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    songs.Sort();
                    break;

                case 2:
                    songs.Sort(new RatingComparer()); 
                    break;

                case 3:
                    songs.Sort(new PopularityComparer());
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-10} {5,-15}", "Name", "Artist", "Song Type", "Rating", "No of Downloads", "Date of Download");
            foreach (var song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
