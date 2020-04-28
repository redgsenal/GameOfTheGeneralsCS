using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierPrivate : SoldierPiece
    {
        public SoldierPrivate(BoardLocation location, Player player, ColorSide color) : base(location, player, color){}
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Private_Soldier;
            this.RankValue = 100;
        }
        public override SoldierPiece Challenge(SoldierPiece piece)
        {
            if (piece is SoldierSpy)
            {
                piece.Eliminate();
                this.CurrentLocation = piece.CurrentLocation;
                piece.RemoveFromBoard();
                return this;
            }
            this.Eliminate();
            piece.CurrentLocation = this.CurrentLocation;
            this.RemoveFromBoard();
            return piece;
        }

    }
}
