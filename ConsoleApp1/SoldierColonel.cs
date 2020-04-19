using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierColonel : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Colonel;
            this.RankValue = 800;
        }
    }
}
