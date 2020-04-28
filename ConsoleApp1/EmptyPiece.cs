using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class EmptyPiece: SoldierPiece
    {
        public EmptyPiece(BoardLocation location)
        {
            InitializeRank();
            this.Color = ColorSide.NUETRAL;
            this.CurrentLocation = location;
        }
        public EmptyPiece(BoardLocation location, Player player, ColorSide color) : base(location, player, color) { }
        public override void InitializeRank()
        {
            this.RankLevel = Rank.No_Rank;
            this.RankValue = 0;
        }
    }
}
