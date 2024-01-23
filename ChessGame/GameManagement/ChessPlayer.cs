using ChessGame.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.GameManagement
{
    public class ChessPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Color GameColor{get; set; }

        public ChessPlayer() 
        {
            // TOD DO:
            throw new Exception();
        }
    }
}