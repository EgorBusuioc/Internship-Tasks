using ChessGame.Builders;
using ChessGame.GameManagement;
using ChessGame.UIEntities;

namespace ChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUIPresenter presenter = new ConsoleUIPresenter();

            GameManager manager = new GameManager(presenter, new ChessPlayer(), new ChessPlayer());

            // options and palyers can be initialized from app.config file

            manager.StartGame(GameOptionsBuilder.BuildOptions());
            
        }
    }
}