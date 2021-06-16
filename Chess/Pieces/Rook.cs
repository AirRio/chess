using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Rook : Piece
    {
        public Rook(PlayerColor color)
        {
            Color = color;
            Type = ChessType.Rook;
        }

        public override bool CanMoveFromTo(int x, int y, int X, int Y)
        {
            if (Math.Abs(X - x) == 0 || Math.Abs(Y - y) == 0)
            {
                return true;
            }

            return false;
        }

        public override IEnumerable<Cage> Move(int x, int y, int X, int Y)
        {
            if (X < x && Y == y)
            {
                while (x != X)
                {
                    yield return new Cage(x, y);
                    x--;
                }
            }
            if (X > x && Y == y)
            {
                while (x != X)
                {
                    yield return new Cage(x, y);
                    x++;
                }
            }
            if (X == x && Y < y)
            {
                while (y != Y)
                {
                    yield return new Cage(x, y);
                    y--;
                }
            }
            if (X == x && Y > y)
            {
                while (y != Y)
                {
                    yield return new Cage(x, y);
                    y++;
                }
            }
        }

    }
}
