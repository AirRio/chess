using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PlayerColor color)
        {
            Color = color;
            Type = ChessType.Bishop;
        }

        public override bool CanMoveFromTo(int x, int y, int X, int Y)
        {
            if (Math.Abs(X - x) == Math.Abs(Y - y))
            {
                return true;
            }

            return false;
        }

        public override IEnumerable<Cage> Move(int x, int y, int X, int Y)
        {
            if(X < x && Y > y)
            {
                while(x != X && y != Y)
                {
                    yield return new Cage(x, y);
                    x--;
                    y++;
                }
            }
            if (X < x && Y < y)
            {
                while (x != X && y != Y)
                {
                    yield return new Cage(x, y);
                    x--;
                    y--;
                }
            }
            if (X > x && Y < y)
            {
                while (x != X && y != Y)
                {
                    yield return new Cage(x, y);
                    x++;
                    y--;
                }
            }
            if (X > x && Y > y)
            {
                while (x != X && y != Y)
                {
                    yield return new Cage(x, y);
                    x++;
                    y++;
                }
            }
        }

    }
}
