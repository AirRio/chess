using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public enum ChessType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn,
    }

    public abstract class Piece
    {
        public ChessType Type { get; protected set; }

        public PlayerColor Color { get; protected set; }

        public abstract bool CanMoveFromTo(int x, int y, int X, int Y);

        public abstract IEnumerable<Cage> Move(int x, int y, int X, int Y);

    }
}
