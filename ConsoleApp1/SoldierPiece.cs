using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public enum Rank
    {
        No_Rank,
        Flag_Rank,
        Spy,
        Private_Soldier,
        Sergeant,
        Second_Lieutenant,
        First_Lieutenant,
        Captain,
        Major,
        Lieutenant_Colonel,
        Colonel,
        Brigadier_General,
        Major_General,
        Lieutenant_General,
        General,
        Five_Star_General
    }
    public class SoldierPiece : IBoardPiece
    {
        public SoldierPiece()
        {
            InitializeRank();
            CurrentLocation = new BoardLocation();
        }
        public SoldierPiece(BoardLocation location)
        {
            InitializeRank();
            CurrentLocation = location;
        }
        public SoldierPiece(Rank rank, int rankValue, BoardLocation location)
        {
            RankLevel = rank;
            RankValue = rankValue;
            CurrentLocation = location;
        }
        public virtual void InitializeRank()
        {
            RankLevel = Rank.No_Rank;
            RankValue = 0;
        }
        public Rank RankLevel { get; set; } = Rank.No_Rank;
        public int RankValue { get; set; } = -1;
        public bool IsEliminated { get; set; } = false;
        public BoardLocation CurrentLocation { get; set; }
        public bool IsSameBoardLocation(BoardLocation location)
        {
            return CurrentLocation.BoardX == location.BoardX && CurrentLocation.BoardY == location.BoardY;
        }
        public bool IsPieceSameBoadLocation(SoldierPiece piece)
        {
            return IsSameBoardLocation(piece.CurrentLocation);
        }
        public void Challenge(SoldierPiece piece)
        {
            if (piece.RankValue < this.RankValue)
            {
                piece.Eliminate();
            }
            else
            {
                this.Eliminate();
            }                
        }

        public void Eliminate()
        {
            IsEliminated = true;
        }

        public void Move(BoardLocation location)
        {
            this.CurrentLocation = location;
        }
        public string RankName()
        {
            return RankLevel.ToString().Replace("_", " ");
        }
    }
}
