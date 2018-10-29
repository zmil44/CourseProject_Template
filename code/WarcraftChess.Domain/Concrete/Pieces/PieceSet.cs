using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    class PieceSet
    {
        List<Piece> pieces = new List<Piece>();
        PieceColor color = new PieceColor();
    }
}
