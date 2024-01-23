using ChessGame.BoardEntities;
using ChessGame.UIEntities;

namespace ChessGame.GameManagement
{
    public class GameManager
    {
        ChessBoard _board;
        ChessPlayer _whitePlayer;
        ChessPlayer _blackPlayer;
        IUIPresenter _ui;

        ChessGameOptions _gameOptions;

        public GameManager(IUIPresenter ui, ChessPlayer whitePlayer, ChessPlayer blackPlayer) 
        {
            _ui = ui;
            _whitePlayer = whitePlayer;
            _blackPlayer = blackPlayer;
        }

        public void StartGame(ChessGameOptions options)
        {
            _gameOptions = options;
            throw new Exception();
        }
        public void PauseGame() 
        {
            throw new Exception();
        }

        public void StopGame() 
        {
            throw new Exception();
        }

    }
}