using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierGeneral : SoldierPiece
    {
        public SoldierGeneral(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.General;
            this.RankValue = 5000;
        }
    }
}
