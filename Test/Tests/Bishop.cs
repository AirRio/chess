using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Tests
{
    public class BishopTest
    {
        [Test]
        public void CanBishopMove_ShouldReturnTrue()
        {
            new Bishop(PlayerColor.Black).CanMoveFromTo(0, 5, 4, 1).Should().BeTrue();
        }

        [Test]
        public void CanBishopMove_ShouldReturnFalse()
        {
            new Bishop(PlayerColor.Black).CanMoveFromTo(0, 5, 2, 2).Should().BeFalse();
        }
    }
}
