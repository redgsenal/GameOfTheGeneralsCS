using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    class SoldierLieutenantGeneral : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Lieutenant_General;
            this.RankValue = 8;
        }
    }
}
