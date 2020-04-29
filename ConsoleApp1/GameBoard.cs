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
        public static List<SoldierPiece> CreateBoardSoldierPieces(SoldierPiece piece, int quantity)
        {
            List<SoldierPiece> pieces = new List<SoldierPiece>();
            if (piece == null || quantity < 1)
                return pieces;
            while (pieces.Count < quantity)
            {
                pieces.Add(piece);
            }
            return pieces;
        }

        public List<SoldierPiece> BuildBoardSoldierPieces(Player player, ColorSide colorSide)
        {
            List<SoldierPiece> pieces = new List<SoldierPiece>();
            int backrow = 1;
            int middlerow = 2;
            int frontrow = 3;
            if (colorSide == ColorSide.BLACK)
            {
                backrow = 8;
                middlerow = 7;
                frontrow = 6;
            }
            // 6 privates            
            pieces.Add(new SoldierPrivate(new BoardLocation(1, frontrow), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(2, frontrow), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(3, frontrow), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(4, frontrow), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(5, frontrow), player, colorSide));
            pieces.Add(new SoldierPrivate(new BoardLocation(6, frontrow), player, colorSide));
            // 2 spies
            pieces.Add(new SoldierSpy(new BoardLocation(7, frontrow), player, colorSide));
            pieces.Add(new SoldierSpy(new BoardLocation(8, frontrow), player, colorSide));
            // remaining pieces
            pieces.Add(new SoldierSergeant(new BoardLocation(9, frontrow), player, colorSide));
            pieces.Add(new SoldierSecondLieutenant(new BoardLocation(1, middlerow), player, colorSide));
            pieces.Add(new SoldierFirstLieutenant(new BoardLocation(2, middlerow), player, colorSide));
            pieces.Add(new SoldierCaptain(new BoardLocation(3, middlerow), player, colorSide));
            pieces.Add(new SoldierMajor(new BoardLocation(4, middlerow), player, colorSide));
            pieces.Add(new SoldierLieutenantColonel(new BoardLocation(5, middlerow), player, colorSide));
            pieces.Add(new SoldierColonel(new BoardLocation(6, middlerow), player, colorSide));
            pieces.Add(new SoldierBrigadierGeneral(new BoardLocation(7, middlerow), player, colorSide));
            pieces.Add(new SoldierMajorGeneral(new BoardLocation(8, middlerow), player, colorSide));
            pieces.Add(new SoldierLieutenantGeneral(new BoardLocation(9, middlerow), player, colorSide));
            pieces.Add(new SoldierGeneral(new BoardLocation(1, backrow), player, colorSide));
            pieces.Add(new SoldierFlag(new BoardLocation(5, backrow), player, colorSide));
            pieces.Add(new SoldierFiveStarGeneral(new BoardLocation(9, backrow), player, colorSide));
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
            Console.WriteLine($"board pieces size: {BoardSoldierPieces.Count}");
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
                throw new ApplicationException($"New location is not empty. {p2}");
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
