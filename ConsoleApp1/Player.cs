using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public class Player
    {
        public Player(string name, string hcolor, List<SoldierPiece> pieces, ColorSide side)
        {
            Name = name;
            HexColor = hcolor;
            SoldierPieces = pieces;
            PlayingSide = side;
        }
        public string Name { get; set; }
        public string HexColor { get; set; }
        public ColorSide PlayingSide { get; set; }
        public List<SoldierPiece> SoldierPieces { get; set; }
        public void PlaceSoldierPiece(SoldierPiece piece, int x, int y)
        {
            PlaceSoldierPiece(piece, new BoardLocation(x, y));
        }
        public SoldierPiece GetSoldierPiece(Rank rankLevel)
        {
            if (SoldierPieces == null || SoldierPieces.Count == 0)
            {
                return null;
            }
            foreach(SoldierPiece piece in SoldierPieces)
            {
                if (piece.RankLevel.ToString().Equals(rankLevel.ToString()))
                    return piece;
            }
            return null;
        }
        public void PlaceSoldierPiece(SoldierPiece piece, BoardLocation location)
        {
            piece.CurrentLocation = location;
        }
        public BoardLocation GetSoldierPieceLocation(SoldierPiece piece)
        {
            if (SoldierPieces == null || SoldierPieces.Count == 0 || piece == null) {
                return null;
            }
            foreach (SoldierPiece p in SoldierPieces)
            {
                if (piece.GetType().Equals(p.GetType()))
                {
                    return p.CurrentLocation;
                }
            }
            return null;                
        }
    }
}
