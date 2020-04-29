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
        NUETRAL,
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

        public void ValidateChallenge(SoldierPiece piece)
        {
            if (piece.Equals(this))
            {
                throw new System.ApplicationException("Cannot challenge piece to itself.");
            }
            if (piece.Color.Equals(this.Color))
            {
                throw new System.ApplicationException("Cannot challenge piece of the same color/side/team.");
            }
        }

        public virtual SoldierPiece Challenge(SoldierPiece piece)
        {
            ValidateChallenge(piece);
            if (this.GetType().Equals(piece.GetType()))
            {
                return SwapSoldierPiece(piece, this);
            }
            if (piece.RankValue > this.RankValue)
            {
                Console.WriteLine($"This piece is eliminated {this}");
                return SwapSoldierPiece(this, piece);
            }
            else
            {
                Console.WriteLine($"This piece is eliminated {piece}");
                return SwapSoldierPiece(piece, this);
            }
        }

        public void RemoveFromBoard()
        {
            this.CurrentLocation = new BoardLocation(0, 0);
        }

        public void Eliminate()
        {
            IsEliminated = true;
        }

        public void Move(BoardLocation newLocation)
        {
            if (!IsValidMove(newLocation))
            {
                throw new ApplicationException($"Invalid move to new location {newLocation.Coordinates()}");
            }
            this.CurrentLocation = newLocation;
        }

        private bool IsValidMove(BoardLocation newLocation)
        {
            if ((newLocation == null) || 
                (!newLocation.IsValidLocation()) ||                
                // is piece is already removed
                (newLocation.IsRemovedLocation())) 
            {
                return false;
            }
            if (newLocation.BoardX == this.CurrentLocation.BoardX)
            {
                return (Math.Abs(newLocation.BoardY - this.CurrentLocation.BoardY) == 1);
            }
            if (newLocation.BoardY == this.CurrentLocation.BoardY)
            {
                return (Math.Abs((newLocation.BoardX - this.CurrentLocation.BoardX)) == 1);
            }
            Console.WriteLine($"current location: {this.CurrentLocation}");
            Console.WriteLine($"new location: {newLocation}");
            return false;
        }

        public string RankName()
        {
            return RankLevel.ToString().Replace("_", " ").Replace("Soldier", String.Empty).Replace("Rank", String.Empty).Trim(); ;
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
            return ($"{CurrentLocation.Coordinates()}; {RankName()}; {RankValue}; {Color}; {IsEliminated}");
        }

        public SoldierPiece SwapSoldierPiece(SoldierPiece losingPiece, SoldierPiece winnerPiece)
        {            
            losingPiece.Eliminate();            
            losingPiece.RemoveFromBoard();
            Console.WriteLine($"{winnerPiece.Color} - {winnerPiece.RankName()} wins over {losingPiece.Color} - {losingPiece.RankName()} at {winnerPiece.CurrentLocation.Coordinates()}");
            return winnerPiece;
        }
    }
}
