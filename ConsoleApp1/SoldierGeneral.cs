using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class SoldierGeneral : SoldierPiece
    {
        public SoldierGeneral() : base() { }
        public SoldierGeneral (BoardLocation location) : base(location)
        {            
        }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.General;
            this.RankValue = 9;
        }
    }
}
