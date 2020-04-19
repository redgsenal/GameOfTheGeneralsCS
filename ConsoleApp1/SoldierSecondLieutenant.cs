using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    class SoldierSecondLieutenant : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Second_Lieutenant;
            this.RankValue = 300;
        }
    }
}
