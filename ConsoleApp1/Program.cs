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

            // major black
            game.RelocateSoldierPiece(new BoardLocation(4, 7), new BoardLocation(4, 5));
            // 1st lt. white
            game.RelocateSoldierPiece(new BoardLocation(2, 2), new BoardLocation(4, 4));

            // cap white vs cap black
            game.RelocateSoldierPiece(new BoardLocation(3, 2), new BoardLocation(3, 4));
            game.RelocateSoldierPiece(new BoardLocation(3, 7), new BoardLocation(3, 5));

            game.ListBoardSoldierPieces();

            game.MoveSoldierPiece(new BoardLocation(7, 5), new BoardLocation(7, 4));
            
            game.MoveSoldierPiece(new BoardLocation(4, 5), new BoardLocation(4, 4));
            game.MoveSoldierPiece(new BoardLocation(8, 5), new BoardLocation(8, 4));

            game.MoveSoldierPiece(new BoardLocation(3, 5), new BoardLocation(3, 4));

            game.ListBoardSoldierPieces();
            game.ListEliminatedSoldierPieces();
        }
    }
}
