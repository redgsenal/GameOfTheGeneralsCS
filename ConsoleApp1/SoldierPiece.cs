using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    // white: starts at y = 1 ends 8
    // black: start at y = 8, end 1
    public enum ColorSide
    {
        WHITE,
        BLACK
    }
    public class SoldierPiece : IBoardPiece, IEquatable<SoldierPiece>
    {        
        public Rank RankLevel { get; set; } = Rank.No_Rank;
        public int RankValue { get; set; } = -1;
        public bool IsEliminated { get; set; } = false;
        public BoardLocation CurrentLocation { get; set; }
        public Player Player { get; set; }
        public ColorSide Color { get; set; }
        public SoldierPiece()
        {
            InitializeRank();
            CurrentLocation = new BoardLocation();
        }
        public SoldierPiece(BoardLocation location, Player player, ColorSide color) 
        {
            InitializeRank();
            this.CurrentLocation = location;
            this.Player = player;
            this.Color = color;
        }
        public SoldierPiece(BoardLocation location)
        {
            InitializeRank();
            CurrentLocation = location;
        }
        public SoldierPiece(Rank rank, int rankValue, BoardLocation location, Player player, ColorSide color)
        {
            RankLevel = rank;
            RankValue = rankValue;
            CurrentLocation = location;
            Player = player;
            Color = color;
        }
        public virtual void InitializeRank()
        {
            RankLevel = Rank.No_Rank;
            RankValue = 0;
        }
        
        public bool IsSameBoardLocation(BoardLocation location)
        {
            return this.CurrentLocation.Equals(location);
        }
        public bool IsPieceSameBoadLocation(SoldierPiece piece)
        {
            return IsSameBoardLocation(piece.CurrentLocation);
        }
        public void Challenge(SoldierPiece piece)
        {
            if (piece.Equals(this))
            {
                throw new System.ApplicationException("Cannot challenge piece to itself.");
            }
            if (piece.Color.Equals(this.Color)){
                throw new System.ApplicationException("Cannot challenge piece of the same color.");
            }
            if (!piece.IsSameBoardLocation(this.CurrentLocation))
            {
                throw new System.ApplicationException("Cannot challenge piece not on same location.");
            }
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

        public bool Equals([AllowNull] SoldierPiece other)
        {
            if (!EqualType(other))
            {
                return false;
            }
            return (IsSameBoardLocation(other.CurrentLocation))
                && (EqualColor(other))
                && (EqualRank(other));            
        }
        public bool EqualType([AllowNull] SoldierPiece other)
        {
            return (other != null && (other is SoldierPiece));
        }
        public bool EqualColor([AllowNull] SoldierPiece other)
        {
            return this.Color.Equals(other.Color);
        }
        public bool EqualRank([AllowNull] SoldierPiece other)
        {            
            return (this.RankValue.Equals(other.RankValue));
        }

        public override string ToString()
        {
            return ($"{CurrentLocation.Coordinates()}; {RankName()}; {RankValue}; {Color}");
        }
    }
}
