using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierMajor : SoldierPiece
    {
        public SoldierMajor(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Major;
            this.RankValue = 600;
        }
    }
}
