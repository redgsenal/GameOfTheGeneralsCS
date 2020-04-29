using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierFlag : SoldierPiece
    {
        public SoldierFlag(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Flag_Rank;
            this.RankValue = 1;
        }
        public override SoldierPiece Challenge(SoldierPiece piece)
        {
            ValidateChallenge(piece);
            if (piece is SoldierFlag)
            {
                return SwapSoldierPiece(piece, this);
            }
            return base.Challenge(piece);
        }
    }
}
