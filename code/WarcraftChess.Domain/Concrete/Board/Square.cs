using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftChess.Domain.Concrete
{
    public class Square
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Square(int i,int j)
        {
            Row = i;
            Column = j;
        }

        public Square()
        {
        }
    }
}
