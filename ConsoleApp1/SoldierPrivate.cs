using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierPrivate : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Private_Soldier;
            this.RankValue = 100;
        }       
    }
}
