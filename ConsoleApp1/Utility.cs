using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class Utility
    {
        public static List<SoldierPiece> CreateBoardSoldierPieces(SoldierPiece piece, int quantity)
        {
            List<SoldierPiece> pieces = new List<SoldierPiece>();
            if (piece == null || quantity < 1)
                return pieces;
            for(int i = 0; i < quantity; i++)
            {
                pieces.Add(piece);
            }
            return pieces;
        }
    }
}
