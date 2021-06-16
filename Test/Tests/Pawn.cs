using Chess;
using Chess.Pieces;
using FluentAssertions;
using NUnit.Framework;


namespace Test.Tests
{
    public class PawnTest
    {
        [Test]
        public void CanPawnMove_ShouldReturnTrue()
        {
            new Pawn(PlayerColor.White).CanMoveFromTo(5, 4, 4, 4).Should().BeTrue();
        }

        [Test]
        public void CanPawnMove_ShouldReturnFalse()
        {
            new Pawn(PlayerColor.White).CanMoveFromTo(5, 4, 7, 4).Should().BeFalse();
        }

        [Test]
        public void CanPawnFirstMove_ShouldReturnTrue()
        {
            new Pawn(PlayerColor.White).IsFirstMove(6, 2, 4, 2).Should().BeFalse();
        }

        [Test]
        public void CanPawnMoveToEnd_ShouldReturnTrue()
        {
            new Pawn(PlayerColor.White).IsQueen(1, 2, 0, 2).Should().BeFalse();
        }



    }
}
