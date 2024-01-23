using ChessGame.Pieces;

namespace ChessGame.BoardEntities
{
    public interface IBoardInitializer
    {
        List<ChessPiece> GetPieces();
    }
}