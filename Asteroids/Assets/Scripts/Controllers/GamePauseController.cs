using System;
using UnityEngine;

namespace Controller
{
    class GamePauseController : IController, IGameStateHandler
    {
        public void UpdateState(GameState state)
        {
            if (state == GameState.Pause)
            {
                PauseGame();
            }
            if (state == GameState.Run)
            {
                ResumeGame();
            }
        }

        public void PauseGame()
        {
            Time.timeScale = 0.0f;
        }
        public void ResumeGame()
        {
            Time.timeScale = 1.0f;
        }
    }
}
