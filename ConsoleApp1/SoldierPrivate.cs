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
                return SwapSoldierPiece(this, piece);
            }
            return SwapSoldierPiece(piece, this);
        }

    }
}
