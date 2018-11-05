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
        PieceType type = new PieceType();
        Square location = new Square();
        bool moved { get; set; }
        public Piece(PieceColor color, PieceType type)
        {
            this.color = color;
            this.type = type;
        }

        public Piece()
        {
        }

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
            return false;
        }
    }
}
