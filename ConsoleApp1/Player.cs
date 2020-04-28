using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{   
    public class Player
    {
        public Player(string name, string hcolor, ColorSide side)
        {
            Name = name;
            HexColor = hcolor;
            PlayingSide = side;
        }
        public string Name { get; set; }
        public string HexColor { get; set; }
        public ColorSide PlayingSide { get; set; }
    }
}
