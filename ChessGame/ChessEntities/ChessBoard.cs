using ChessGame.Pieces;

namespace ChessGame.BoardEntities
{
    public class ChessBoard
    {
        List<ChessPiece> ChessPieces { get; set; }

        public ChessBoard()
        {   
        }

        // need to uyse some Initializer
        public void InitializeBoard(IBoardInitializer initializer)
        {
            ChessPieces = initializer.GetPieces();
        }
    }
}