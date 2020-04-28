using System;
using System.Collections.Generic;

namespace GameOfTheGenerals
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game of the Generals!");
            Player playerWhite = new Player("Joe", "#ffffff", ColorSide.WHITE);
            Player playerBlack = new Player("John", "#00000", ColorSide.BLACK);
            GameBoard game = new GameBoard();            
            List<SoldierPiece> b = game.BuildBoardSoldierPieces(playerBlack, ColorSide.BLACK);
            List<SoldierPiece> w = game.BuildBoardSoldierPieces(playerBlack, ColorSide.WHITE);
            game.SetUpBoard(w);
            game.SetUpBoard(b);
            game.ListBoardSoldierPieces();
            Console.WriteLine(game.GetSoldierPiece(4, 5));

            // white spy and private
            game.RelocateSoldierPiece(new BoardLocation(7, 3), new BoardLocation(7, 4));
            game.RelocateSoldierPiece(new BoardLocation(1, 3), new BoardLocation(8, 4));

            // black spy and private
            game.RelocateSoldierPiece(new BoardLocation(7, 6), new BoardLocation(8, 5));
            game.RelocateSoldierPiece(new BoardLocation(1, 6), new BoardLocation(7, 5));
            // Console.WriteLine(game.GetSoldierPiece(4, 6));
            game.ListBoardSoldierPieces();

            game.MoveSoldierPiece(new BoardLocation(7, 5), new BoardLocation(7, 4));
            game.ListEliminatedSoldierPieces();
            game.ListBoardSoldierPieces();
        }
    }
}
