using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine
{
    public class GameEngine : IGameEngine
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public GameEngine(IReadOnlyDictionary<string, int> deck1, IReadOnlyDictionary<string, int> deck2)
        {
            _player1 = new Player(deck1);
            _player2 = new Player(deck2);
        }
    }
}
