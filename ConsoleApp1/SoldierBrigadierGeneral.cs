using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierBrigadierGeneral : SoldierPiece
    {
        public SoldierBrigadierGeneral(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Brigadier_General;
            this.RankValue = 900;
        }
    }
}
