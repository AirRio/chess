using Chess.Interface;
using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Chess
{
    public class Board : IBoard
    {

        public Cell[,] Cells { get; }


        public void Move(int x, int y, int X, int Y)
        {

        }


        public void StartGame()
        {

            var black = PlayerColor.Black;

            Cells[1, 0].Piece = new Pawn(black);
            Cells[1, 1].Piece = new Pawn(black);
            Cells[1, 2].Piece = new Pawn(black);
            Cells[1, 3].Piece = new Pawn(black);
            Cells[1, 4].Piece = new Pawn(black);
            Cells[1, 5].Piece = new Pawn(black);
            Cells[1, 6].Piece = new Pawn(black);
            Cells[1, 7].Piece = new Pawn(black);

            Cells[0, 0].Piece = new Rook(black);
            Cells[0, 1].Piece = new Knight(black);
            Cells[0, 2].Piece = new Bishop(black);
            Cells[0, 3].Piece = new Queen(black);
            Cells[0, 4].Piece = new King(black);
            Cells[0, 5].Piece = new Bishop(black);
            Cells[0, 6].Piece = new Knight(black);
            Cells[0, 7].Piece = new Rook(black);

            var white = PlayerColor.White;

            Cells[6, 0].Piece = new Pawn(white);
            Cells[6, 1].Piece = new Pawn(white);
            Cells[6, 2].Piece = new Pawn(white);
            Cells[6, 3].Piece = new Pawn(white);
            Cells[6, 4].Piece = new Pawn(white);
            Cells[6, 5].Piece = new Pawn(white);
            Cells[6, 6].Piece = new Pawn(white);
            Cells[6, 7].Piece = new Pawn(white);

            Cells[7, 0].Piece = new Rook(white);
            Cells[7, 1].Piece = new Knight(white);
            Cells[7, 2].Piece = new Bishop(white);
            Cells[7, 3].Piece = new Queen(white);
            Cells[7, 4].Piece = new King(white);
            Cells[7, 5].Piece = new Bishop(white);
            Cells[7, 6].Piece = new Knight(white);
            Cells[7, 7].Piece = new Rook(white);


        }
    }
}
