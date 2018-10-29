using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    public class Piece
    {
        PieceColor color = new PieceColor();
        Square location = new Square();
        bool moved { get; set; }

        public Square[] ValidMoves()
        {
            return null;
        }

        public Square[] AttackSquares()
        {
            return null;
        }

        public Square[] CaptureFreeMove()
        {
            return null;
        }
        public bool ToBeCaptured()
        {
            return null
        }
    }
}
