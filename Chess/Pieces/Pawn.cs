using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Pawn : Piece
    {

        public Pawn(PlayerColor color)
        {
            Color = color;
            Type = ChessType.Pawn;
        }

        public bool IsFirstMove(int x, int y, int X, int Y)
        {
            if((x == 1 || x == 6) && (Y == y) && Math.Abs(x-x) == 2   &&  (Color == PlayerColor.White || Color == PlayerColor.Black))
            {
                return true;
            }
            return false;
        }

        public bool IsQueen(int x, int y, int X, int Y)
        {

            if(Color == PlayerColor.Black && X == 0 && Math.Abs(X-x) == 1)
            {
                this.Type = ChessType.Queen;
                return true;
            }
            if (Color == PlayerColor.White && X == 7 && Math.Abs(X - x) == 1)
            {
                this.Type = ChessType.Queen;
                return true;
            }

            return false;
        }

        public override bool CanMoveFromTo(int x, int y, int X, int Y)
        {
            if( (X - x) == -1 && (Y == y) && Color == PlayerColor.White )
            {
                return true;
            }
            if ((X - x) == 1 && (Y == y) && Color == PlayerColor.Black)
            {
                return true;
            }
            return false;
        }

        public override IEnumerable<Cage> Move(int x, int y, int X, int Y)
        {
            yield return new Cage(x, y);
            yield return new Cage(X, Y);
        }


    }
}
