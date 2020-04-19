using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierBrigadierGeneral : SoldierPiece
    {
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Brigadier_General;
            this.RankValue = 900;
        }
    }
}
