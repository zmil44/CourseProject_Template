using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete.Pieces
{
    public class Warrior : Piece
    {
        private bool _isPromoted = false;
        public bool IsPromoted
        {
            get
            {
                return _isPromoted;
            }
            set
            {
                _isPromoted = value;
            }
        }


    }
}
