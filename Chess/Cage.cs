using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public struct Cage
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Cage(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
