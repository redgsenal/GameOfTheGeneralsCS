using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierSergeant : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Sergeant;
            this.RankValue = 200;
        }
    }
}
