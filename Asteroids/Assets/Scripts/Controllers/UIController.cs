using Asteroids.Core;
using Asteroids.Data;
using Asteroids.Models;
using Asteroids.Views;
using System;
using UnityEngine;

namespace Controller
{
    class UIController : IController, IAwakeInitialize, IChangeGameState, IStartInitialize, IDisable
    {
        private readonly BaseUI _inGameUI;
        private readonly BaseUI _mainMenu;
        private readonly IShipModel _shipModel;
        private readonly EnemyDeathObserver _enemyDeathObserver;
        private BaseUI _currentWindow;


        private long _score = 0; // TODO remove from controller


        public event Action<GameState> OnGameStateChanged;


        public UIController(BaseUI inGameUI, BaseUI mainMenu, IShipModel shipModel, EnemyDeathObserver enemyDeathObserver)
        {
            _inGameUI = inGameUI;
            _mainMenu = mainMenu;
            _shipModel = shipModel;
            _enemyDeathObserver = enemyDeathObserver;
        }



        public void AwakeInit()
        {
            _inGameUI.Cancel();
            _mainMenu.Cancel();
            Execute(UIState.MainMenu);

            _shipModel.Health.OnHealthChanged += ShowHealth;
            _enemyDeathObserver.OnEnemyDeath += HandleEnemyDeath;

            var inGameUI = (_inGameUI as IInGameUI);
            inGameUI.SetHp(_shipModel.Health.Health.ToString());

            if (_mainMenu is IMainMenu mainMenu)
            {
                mainMenu.StartSubscribe(StartClick);
                mainMenu.ExitSubscribe(ExitClick);
            }
        }
        public void StartInit()
        {
            OnGameStateChanged?.Invoke(GameState.Pause);
        }


        private void HandleEnemyDeath(EnemyDeathInfo info)
        {
            var ui = _inGameUI as IInGameUI;
            _score += info.Score;
            var scoreCut = _score.CutToLiteralNumber();
            ui.SetScore(scoreCut);
            scoreCut = info.Score.CutToLiteralNumber();
            ui.ShowLog($"{info.Type} killed. + {scoreCut}");
        }

        private void ShowHealth(int health)
        {
            if (_inGameUI is IInGameUI gameUI)
            {
                gameUI.SetHp(health.ToString());
            }
        }



        private void StartClick()
        {
            Execute(UIState.InGameUI);
            OnGameStateChanged?.Invoke(GameState.Run);
        }
        private void ExitClick()
        {
            Debug.Log("Exit button");
        }

        private void Execute(UIState state)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (state)
            {
                case UIState.MainMenu:
                    _currentWindow = _mainMenu;
                    break;

                case UIState.InGameUI:
                    _currentWindow = _inGameUI;
                    break;

                default:
                    break;
            }

            _currentWindow.Execute();
        }

        public void Disable()
        {
            _shipModel.Health.OnHealthChanged -= ShowHealth;
            _enemyDeathObserver.OnEnemyDeath -= HandleEnemyDeath;
        }
    }
}

