using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{   
    public class GameBoard
    {
        public List<SoldierPiece> BoardSoldierPieces { get; set; } = new List<SoldierPiece>();

        public bool HasWinner()
        {            
            return true;
        }

        public List<SoldierPiece> BuildBoardSoldierPieces(Player player, ColorSide colorSide)
        {
            List<SoldierPiece> pieces = new List<SoldierPiece>();
            int y1 = 1;
            int y2 = 2;
            int y3 = 3;
            if (colorSide == ColorSide.BLACK)
            {
                y1 = 8;
                y2 = 7;
                y3 = 6;
            }
            // 6 privates
            pieces.Add(new SoldierPrivate(new BoardLocation(1, y3), player, colorSide));            
            pieces.Add(new SoldierPrivate(new BoardLocation(2, y3), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(3, y3), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(4, y3), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(5, y3), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(6, y3), player, colorSide));
            // 2 spies
            pieces.Add(new SoldierSpy(new BoardLocation(7, y3), player, colorSide));
            pieces.Add(new SoldierSpy(new BoardLocation(8, y3), player, colorSide));
            // remaining pieces
            pieces.Add(new SoldierSergeant(new BoardLocation(1, y2), player, colorSide));
            pieces.Add(new SoldierSecondLieutenant(new BoardLocation(2, y2), player, colorSide));
            pieces.Add(new SoldierFirstLieutenant(new BoardLocation(3, y2), player, colorSide));
            pieces.Add(new SoldierCaptain(new BoardLocation(4, y2), player, colorSide));
            pieces.Add(new SoldierMajor(new BoardLocation(5, y2), player, colorSide));
            pieces.Add(new SoldierLieutenantColonel(new BoardLocation(6, y2), player, colorSide));
            pieces.Add(new SoldierColonel(new BoardLocation(7, y2), player, colorSide));
            pieces.Add(new SoldierBrigadierGeneral(new BoardLocation(8, y2), player, colorSide));
            pieces.Add(new SoldierMajorGeneral(new BoardLocation(9, y2), player, colorSide));
            pieces.Add(new SoldierLieutenantGeneral(new BoardLocation(1, y1), player, colorSide));
            pieces.Add(new SoldierFlag(new BoardLocation(4, y1), player, colorSide));
            pieces.Add(new SoldierGeneral(new BoardLocation(5, y1), player, colorSide));
            pieces.Add(new SoldierFiveStarGeneral(new BoardLocation(9, y1), player, colorSide));
            return pieces;
        }

        public void SetUpBoard(List<SoldierPiece> playerPieces)
        {
            if (BoardSoldierPieces == null)
            {
                BoardSoldierPieces = new List<SoldierPiece>();
            }
            
            foreach(SoldierPiece playerPiece in playerPieces)
            {
                foreach(SoldierPiece piece in BoardSoldierPieces)                
                {
                    if (playerPiece.CurrentLocation.Equals(piece.CurrentLocation))
                    {
                        throw new System.ApplicationException($"Invalid piece location. Location already occupied. {piece.RankName()} at {piece.CurrentLocation.Coordinates()} ");
                    }
                }
                BoardSoldierPieces.Add(playerPiece);                
            }                        
        }

    }
}
