using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    // board
    // white: (1,1) - (4,9)
    // black: (1,5) - (9,8)
    public class BoardLocation
    {
        public BoardLocation()
        {
            BoardX = 0;
            BoardY = 0;
        }
        public BoardLocation(int x, int y)
        {
            BoardX = x;
            BoardY = y;
        }
        public int BoardX { get; set; } = 0;
        public int BoardY { get; set; } = 0;
        public string Coordinates()
        {
            return $"x: {BoardX}, y: {BoardY}";
        }
    }
}
