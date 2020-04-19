using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class Utility
    {
        public static List<SoldierPiece> BuildListBoardSoldierPieces()
        {
            List<SoldierPiece> pieces = new List<SoldierPiece>();
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierFlag(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierPrivate(), 6));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierSpy(), 2));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierFiveStarGeneral(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierGeneral(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierLieutenantGeneral(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierMajorGeneral(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierBrigadierGeneral(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierColonel(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierLieutenantColonel(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierMajor(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierCaptain(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierFirstLieutenant(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierSecondLieutenant(), 1));
            pieces.AddRange(CreateListBoardSoldierPiece(new SoldierSergeant(), 1));
            return pieces;
        }

        public static List<SoldierPiece> CreateListBoardSoldierPiece(SoldierPiece piece, int quantity)
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
