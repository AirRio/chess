using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Cell
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Piece Piece { get; set; }

        public bool CanMove(Cage cage)
        {
            return Piece.CanMoveFromTo(X, Y, cage.X, cage.Y);
        }

        public IEnumerable<Cage> GetMove(Cage cage)
        {
            return Piece.Move(X, Y, cage.X, cage.Y);
        }


    }
}
