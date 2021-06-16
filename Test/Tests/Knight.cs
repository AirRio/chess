using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Tests
{
    public class KnightTest
    {
        [Test]
        public void CanKingMove_ShouldReturnTrue()
        {
            new Knight(PlayerColor.Black).CanMoveFromTo(0, 1, 1, 3).Should().BeTrue();
        }

        [Test]
        public void CanKingMove_ShouldReturnFalse()
        {
            new Knight(PlayerColor.White).CanMoveFromTo(7, 1, 6, 2).Should().BeFalse();
        }
    }
}
