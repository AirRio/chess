using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Interface
{
    public interface IBoard
    {
        public void Move(int x, int y, int X, int Y);
    }
}
