using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfTheGenerals
{
    public interface IBoardPiece
    {
        void InitializeRank();
        // move piece to new x, y location
        void Move(BoardLocation newBoardLocation);
        // mark this piece are elimated and remove this piece from the board
        void Eliminate();
        // challenge this piece with another piece
        void Challenge(SoldierPiece piece);
        string RankName();
    }
}
