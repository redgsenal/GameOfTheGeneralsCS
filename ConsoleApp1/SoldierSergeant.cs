using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierSergeant : SoldierPiece
    {
        public SoldierSergeant(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Sergeant;
            this.RankValue = 200;
        }
    }
}
