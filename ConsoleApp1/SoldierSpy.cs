using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierSpy : SoldierPiece
    {   
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Spy;
            this.RankValue = 1000;
        }       
    }
}
