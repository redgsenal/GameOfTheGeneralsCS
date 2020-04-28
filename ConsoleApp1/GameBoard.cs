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
        public void ListBoardSoldierPieces()
        {
            Console.WriteLine("****");
            foreach (SoldierPiece piece in BoardSoldierPieces)
            {
                Console.WriteLine($"{piece}");
            }
            Console.WriteLine("****");
        }

        public SoldierPiece GetSoldierPiece(int x, int y)
        {
            return GetSoldierPiece(new BoardLocation(x, y));
        }

        public SoldierPiece GetSoldierPiece(BoardLocation loc)
        {
            foreach (SoldierPiece p in BoardSoldierPieces)
            {
                if (p.CurrentLocation.Equals(loc))
                {
                    return p;
                }
            }
            return new EmptyPiece(loc);
        }

        public void RemoveSoldierPiece(SoldierPiece piece)
        {
            piece.CurrentLocation = new BoardLocation(0, 0);
            piece.IsEliminated = true;
        }

        public void MoveSoldierPiece(BoardLocation oldLoc, BoardLocation newLoc)
        {
            SoldierPiece p = GetSoldierPiece(oldLoc);
            SoldierPiece p2 = GetSoldierPiece(newLoc);
            if (p is EmptyPiece)
            {
                throw new ApplicationException($"Location {oldLoc.Coordinates().ToString()} does not contain a piece to move.");
            }
            if (!(p2 is EmptyPiece))
            {
                p.Challenge(p2);
            }
            else
            {
                p.Move(newLoc);
            }            
        }

        public void RelocateSoldierPiece(BoardLocation oldLoc, BoardLocation newLoc)
        {
            SoldierPiece p = GetSoldierPiece(oldLoc);
            SoldierPiece p2 = GetSoldierPiece(newLoc);
            if (p is EmptyPiece)
            {
                throw new ApplicationException($"Location {oldLoc.Coordinates().ToString()} does not contain a piece to move.");
            }
            if (p2 is EmptyPiece)
            {
                p.CurrentLocation = newLoc; 
            }
            else
            {
                throw new ApplicationException("New location is not empty. {p2}");
            }
        }

        public List<SoldierPiece> ListEliminatedSoldierPieces()
        {
            List<SoldierPiece> r = new List<SoldierPiece>();
            foreach (SoldierPiece p in BoardSoldierPieces)
            {
                if (p.IsEliminated)
                {
                    r.Add(p);
                    Console.WriteLine($"{p}");
                }
            }            
            return r;
        }
    }
}
