using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Knight : Piece
    {
        public Knight(PlayerColor color)
        {
            Color = color;
            Type = ChessType.Knight;
        }


        public override bool CanMoveFromTo(int x, int y, int X, int Y)
        {

            if (Math.Abs(X - x) == 2 && Math.Abs(Y - y) == 1) return true;
            if (Math.Abs(X - x) == 1 && Math.Abs(Y - y) == 2) return true;

            return false;
        }

        public override IEnumerable<Cage> Move(int x, int y, int X, int Y)
        {
            yield return new Cage(x, y);
            yield return new Cage(X, Y);
        }
    }
}
