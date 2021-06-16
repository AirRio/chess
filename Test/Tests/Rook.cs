using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Tests
{
    public class RookTest
    {
        [Test]
        public void CanKingMove_ShouldReturnTrue()
        {
            new Rook(PlayerColor.Black).CanMoveFromTo(0, 0, 8, 0).Should().BeTrue();
        }

        [Test]
        public void CanKingMove_ShouldReturnFalse()
        {
            new King(PlayerColor.Black).CanMoveFromTo(0, 0, 8, 8).Should().BeFalse();
        }
    }
}
