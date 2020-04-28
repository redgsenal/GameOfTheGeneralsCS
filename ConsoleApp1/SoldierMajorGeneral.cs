using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    class SoldierMajorGeneral : SoldierPiece
    {
        public SoldierMajorGeneral(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Major_General;
            this.RankValue = 1000;
        }
    }
}
