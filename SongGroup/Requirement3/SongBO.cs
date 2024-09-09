using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class SongBO
    {
        public List<Song> FindSong(List<Song> songList, string type)
        {
            return songList.Where(s => s.SongType == type).ToList();
        }

        public List<Song> FindSong(List<Song> songList, DateTime dateDownloaded)
        {
            return songList.Where(s => s.DateDownloaded.Date == dateDownloaded.Date).ToList();
        }

        public List<Song> FindSong(List<Song> songList, double rating)
        {
            return songList.Where(s => s.Rating == rating).ToList();
        }
    }
}
