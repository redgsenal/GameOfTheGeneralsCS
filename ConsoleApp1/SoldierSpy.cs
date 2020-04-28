using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierSpy : SoldierPiece
    {
        public SoldierSpy(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Spy;
            this.RankValue = 100000;
        }
    }
}
