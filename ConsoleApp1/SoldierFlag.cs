using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierFlag : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Flag_Rank;
            this.RankValue = -1;
        }
    }

}
