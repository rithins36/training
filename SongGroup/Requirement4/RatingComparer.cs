using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public class RatingComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
}
