using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    // white: starts at y = 1 ends 8
    // black: start at y = 8, end 1
    public enum ColorSide
    {
        WHITE,
        BLACK
    }
    public class GameBoard
    {
        public List<Player> players { get; set; } = new List<Player>();
        public List<BoardLocation> locations { get; set; } = new List<BoardLocation>();
        public bool HasWinner()
        {
            foreach(Player p in players)
            {
            }
            return true;
        }

    }
}
