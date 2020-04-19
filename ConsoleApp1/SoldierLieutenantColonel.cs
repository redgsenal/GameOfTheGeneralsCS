using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierLieutenantColonel : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Lieutenant_Colonel;
            this.RankValue = 700;
        }
    }
}
