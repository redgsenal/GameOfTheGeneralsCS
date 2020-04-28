using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierFirstLieutenant : SoldierPiece
    {
        public SoldierFirstLieutenant(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.First_Lieutenant;
            this.RankValue = 400;
        }
    }
}
