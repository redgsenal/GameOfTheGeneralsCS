using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierColonel : SoldierPiece
    {
        public SoldierColonel(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Colonel;
            this.RankValue = 800;
        }
    }
}
