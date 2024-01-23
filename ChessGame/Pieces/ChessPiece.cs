using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pieces
{
    public abstract class ChessPiece
    {
        Color Color { get; } // autoproperty
        CellCoordinate CurrentCoordinate { get; set; }
        public abstract void MoveTo(CellCoordinate coordinate); 
        
    }
}