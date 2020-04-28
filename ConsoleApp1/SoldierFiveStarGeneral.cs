using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierFiveStarGeneral : SoldierPiece
    {
        public SoldierFiveStarGeneral(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.Five_Star_General;
            this.RankValue = 10000;
        }        
    }
}
