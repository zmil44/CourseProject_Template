using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    public class Board
    {
        public Square[,] ChessBoard = new Square[9,9];
        PieceSet[] pieceSets = new PieceSet[2];

        public void CreateBoard()
        {
            for(int i=1;i<=8;i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    ChessBoard[i, j] = new Square(i, j);
                }
            }
        }
    }
}
