using System;
using System.Collections.Generic;

namespace GameOfTheGenerals
{
    class Program
    {   
        static void Main(string[] args)
        {
            ConWrite("Welcome to Game of the Generals!");
            Player playerWhite = new Player("Joe", "#ffffff", ColorSide.WHITE);
            Player playerBlack = new Player("John", "#00000", ColorSide.BLACK);
            GameBoard game = new GameBoard();            
            List<SoldierPiece> blackPieces = game.BuildBoardSoldierPieces(playerBlack, ColorSide.BLACK);
            game.SetUpBoard(blackPieces);

            /*List<SoldierPiece> whitePieces = new List<SoldierPiece>();
            // 1 flag
            whitePieces.Add(new SoldierPrivate(new BoardLocation(1, 1), playerWhite, ColorSide.WHITE));
            // 6 privates
            whitePieces.Add(new SoldierPrivate(new BoardLocation(2, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierPrivate(new BoardLocation(3, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierPrivate(new BoardLocation(4, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierPrivate(new BoardLocation(5, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierPrivate(new BoardLocation(6, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierPrivate(new BoardLocation(7, 1), playerWhite, ColorSide.WHITE));
            // 2 spies
            whitePieces.Add(new SoldierSpy(new BoardLocation(8, 1), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierSpy(new BoardLocation(1, 2), playerWhite, ColorSide.WHITE));
            // remaining pieces
            whitePieces.Add(new SoldierSergeant(new BoardLocation(2, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierSecondLieutenant(new BoardLocation(3, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierFirstLieutenant(new BoardLocation(4, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierCaptain(new BoardLocation(5, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierMajor(new BoardLocation(6, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierLieutenantColonel(new BoardLocation(7, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierColonel(new BoardLocation(8, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierBrigadierGeneral(new BoardLocation(9, 2), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierMajorGeneral(new BoardLocation(1, 3), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierLieutenantGeneral(new BoardLocation(2, 3), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierGeneral(new BoardLocation(3, 3), playerWhite, ColorSide.WHITE));
            whitePieces.Add(new SoldierFiveStarGeneral(new BoardLocation(4, 3), playerWhite, ColorSide.WHITE));
            game.SetUpBoard(whitePieces);*/
            foreach (SoldierPiece soldier in game.BoardSoldierPieces)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        /*private static void BuildSoldierPieces()
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
        }*/

        private static void ConWrite(string s)
        {
            Console.WriteLine(s);
        }
    }
}
