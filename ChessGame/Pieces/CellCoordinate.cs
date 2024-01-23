using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Pieces
{
    public class CellCoordinate
    {
        public char Row { get; set; }
        public char Column { get; set;}

        public CellCoordinate(char column, char row)
        {
            Column = column;
            Row = row;
        }
    }
}