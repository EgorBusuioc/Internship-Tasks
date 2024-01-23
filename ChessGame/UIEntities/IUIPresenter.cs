using ChessGame.Pieces;

namespace ChessGame.UIEntities
{
    public interface IUIPresenter
    {
        CellCoordinate GetCellCoordinate();
        void OutputCurrentBoard();
    }
}