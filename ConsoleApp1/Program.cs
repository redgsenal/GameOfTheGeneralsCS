using System;
using System.Collections.Generic;

namespace GameOfTheGenerals
{
    class Program
    {   
        static void Main(string[] args)
        {
            ConWrite("Welcome to Game of the Generals!");
            Player playerA = new Player("Joe", "#c0c0c0", Utility.BuildListBoardSoldierPieces(), ColorSide.WHITE);
            playerA.PlaceSoldierPiece(SoldierMajor, new BoardLocation(5, 5));
            foreach(SoldierPiece piece in playerA.SoldierPieces)
            {
                ConWrite($"location {piece.CurrentLocation.Coordinates()}");
            }

            //Player playerB = new Player("John", "#fffff", Utility.BuildListBoardSoldierPieces());
            //BuildSoldierPieces();
        }

        private static void BuildSoldierPieces()
        {
            ConWrite("Build games soldier pieces...");
            List<SoldierPiece> soldiers = Utility.BuildListBoardSoldierPieces();
            foreach(SoldierPiece soldier in soldiers)
            {
                ConWrite(soldier.RankName());
                ConWrite(soldier.CurrentLocation.BoardX.ToString());
                ConWrite(soldier.CurrentLocation.BoardY.ToString());

            }
            ConWrite(soldiers.Count.ToString());
        }

        private static void ConWrite(string s)
        {
            Console.WriteLine(s);
        }
    }
}
