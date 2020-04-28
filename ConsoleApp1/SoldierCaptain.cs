using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierCaptain : SoldierPiece
    {
        public SoldierCaptain(BoardLocation location, Player player, ColorSide color) : base(location, player, color) {}

        public override void InitializeRank()
        {
            this.RankLevel = Rank.Captain;
            this.RankValue = 500;
        }
    }
}
