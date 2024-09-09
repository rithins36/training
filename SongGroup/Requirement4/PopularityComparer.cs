﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public class PopularityComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return x.NumberOfDownloads.CompareTo(y.NumberOfDownloads);
        }
    }
}
