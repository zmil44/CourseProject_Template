using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    class Move
    {
        Square startSquare = new Square();
        Square endSquare = new Square();
        Piece piece = new Piece();
        Piece caputredPiece = new Piece();

        public Move()
        {

        }
}
    }
}
