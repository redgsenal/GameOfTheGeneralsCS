using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierFirstLieutenant : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.First_Lieutenant;
            this.RankValue = 400;
        }
    }
}
