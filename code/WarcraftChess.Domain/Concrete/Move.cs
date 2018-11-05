using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    public class Move
    {
        Square startSquare = new Square();
        Square endSquare = new Square();
        Piece piece = new Piece();
        Piece caputredPiece = new Piece();

        public Move(Piece piece, Square startSquare, Square endSquare)
        {
            this.piece = piece;
            this.startSquare = startSquare;
            this.endSquare = endSquare;
        }

    }
}
