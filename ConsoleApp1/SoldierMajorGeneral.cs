using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    class SoldierMajorGeneral : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Major_General;
            this.RankValue = 700;
        }
    }
}
