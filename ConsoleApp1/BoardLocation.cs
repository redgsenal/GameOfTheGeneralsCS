using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GameOfTheGenerals
{
    // board
    // white: (1,1) - (4,9)
    // black: (1,5) - (9,8)
    public class BoardLocation : IEquatable<BoardLocation>
    {
        public BoardLocation()
        {
            BoardX = 0;
            BoardY = 0;
        }
        public BoardLocation(int x, int y)
        {
            if (!IsValidCoordinates(x, y))
            {
                throw new System.ApplicationException($"Invalid board coordinates ({x}, {y})");
            }
            BoardX = x;
            BoardY = y;
        }
        public int BoardX { get; set; } = 0;
        public int BoardY { get; set; } = 0;
        public string Coordinates()
        {
            return $"x: {BoardX}, y: {BoardY}";
        }
        public bool Equals([AllowNull] BoardLocation other)
        {
            if (other == null || !(other is BoardLocation))
            {
                return false;
            }
            return (other.BoardX == this.BoardX) && (other.BoardY == this.BoardY);
        }

        public bool IsValidLocation()
        {
            return IsValidCoordinates(BoardX, BoardY);
        }

        public bool IsValidCoordinates(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return true;
            }                
            return IsValidMinMax(x, 1, 9) || IsValidMinMax(y, 1, 8);
        }
        private bool IsValidMinMax(int v, int min, int max) 
        {            
            return (v > min || v < max);
        }
    }
}
