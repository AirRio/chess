using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Tests
{
    public class QueenTest
    {

        [Test]
        public void CanQueenMove_ShouldReturnTrue()
        { 
            var queen = new Queen(PlayerColor.White);
            var result = queen.CanMoveFromTo(0, 0, 8, 8);

            result.Should().BeTrue();
        }

        [Test]
        public void CanQueenMove_ShouldReturnFalse()
        {
            var queen = new Queen(PlayerColor.Black);
            var result = queen.CanMoveFromTo(0, 0, 7, 8);

            result.Should().BeFalse();
        }
    }
}
