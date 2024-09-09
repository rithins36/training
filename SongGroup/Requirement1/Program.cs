namespace Requirement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Song 1 Details");
            string[] song1Details = Console.ReadLine().Split(',');
            Song song1 = new Song(song1Details[0], song1Details[1], song1Details[2], double.Parse(song1Details[3]), int.Parse(song1Details[4]), DateTime.ParseExact(song1Details[5], "dd-mm-yyyy", null));
            Console.WriteLine();
            Console.WriteLine("Enter Song 2 Details");
            string[] song2Details = Console.ReadLine().Split(',');
            Song song2 = new Song(song2Details[0], song2Details[1], song2Details[2], double.Parse(song2Details[3]), int.Parse(song2Details[4]), DateTime.ParseExact(song2Details[5], "dd-mm-yyyy", null));
            Console.WriteLine();
            Console.WriteLine("Song 1");
            Console.WriteLine(song1.ToString());
            Console.WriteLine();
            Console.WriteLine("Song 2");
            Console.WriteLine(song2.ToString());
            Console.WriteLine();
            if (song1.Equals(song2))
            {
                Console.WriteLine("Song 1 is same as Song 2");
            }
            else
            {
                Console.WriteLine("Song 1 and Song 2 are different");
            }

        }
    }
}
