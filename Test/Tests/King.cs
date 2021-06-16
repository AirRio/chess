using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Tests
{
    public class KingTest
    {
        [Test]
        public void CanKingMove_ShouldReturnTrue()
        {
            new King(PlayerColor.Black).CanMoveFromTo(0, 2, 1, 2).Should().BeTrue();
        }

        [Test]
        public void CanKingMove_ShouldReturnFalse()
        {
            new King(PlayerColor.Black).CanMoveFromTo(0, 2, 2, 2).Should().BeFalse();
        }
    }
}
