using System;

namespace Controller
{
    public interface IChangeGameState
    {
        public event Action<GameState> OnGameStateChanged;
    }

}
