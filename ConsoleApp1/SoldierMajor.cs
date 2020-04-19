using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierMajor : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Major;
            this.RankValue = 600;
        }
    }
}
