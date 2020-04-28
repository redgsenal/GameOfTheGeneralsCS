using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    class SoldierLieutenantGeneral : SoldierPiece
    {
        public SoldierLieutenantGeneral(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Lieutenant_General;
            this.RankValue = 2000;
        }
    }
}
