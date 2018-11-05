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
        public void CreatePieceSet(PieceColor color)
        {
            this.color = color;
            //Creating Warriors
            for (int i = 0; i < 8; i++)
            {
                pieces.Add(new Piece(color, PieceType.Warrior));
              
            }
            //creating Hunters, Mages, and paladins for both teams
            for(int i=0;i<2;i++)
            {
                
                    pieces.Add(new Piece(color, PieceType.Hunter));
                    pieces.Add(new Piece(color, PieceType.Paladin));
                    pieces.Add(new Piece(color, PieceType.Mage));

            }
            // Creating Druid for both teams and shaman for red and priest for blue
            
            if(this.color==PieceColor.Blue)
            {
                pieces.Add(new Piece(color, PieceType.Druid));
                pieces.Add(new Piece(color, PieceType.Priest));
            }
            else
            {
                pieces.Add(new Piece(color, PieceType.Druid));
                pieces.Add(new Piece(color, PieceType.Shaman));

            }
        }
        
    }
}
