using System;

namespace Controller
{
    public interface IEndGame
    {
        public event Action<bool> OnGameEnd;
    }
}

