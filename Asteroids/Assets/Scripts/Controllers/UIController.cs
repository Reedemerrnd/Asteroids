using Asteroids.Models;
using Asteroids.Views;
using Inputs;
using System;
using UnityEngine;

namespace Controller
{
    class UIController : IController, IAwakeInitialize, IChangeGameState, IStartInitialize
    {
        private readonly BaseUI _inGameUI;
        private readonly BaseUI _mainMenu;
        private readonly IShipModel _shipModel;
        private BaseUI _currentWindow;

        public UIController(BaseUI inGameUI, BaseUI mainMenu, IShipModel shipModel)
        {
            _inGameUI = inGameUI;
            _mainMenu = mainMenu;
            _shipModel = shipModel;
        }

        public event Action<GameState> OnGameStateChanged;

        public void AwakeInit()
        {
            _inGameUI.Cancel();
            _mainMenu.Cancel();
            Execute(UIState.MainMenu);

            _shipModel.Health.OnHealthChanged += ShowHealth;
            (_inGameUI as IInGameUI).SetHp(_shipModel.Health.Health.ToString());

            if (_mainMenu is IMainMenu mainMenu)
            {
                mainMenu.StartSubscribe(StartClick);
                mainMenu.ExitSubscribe(ExitClick);
            }
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

        public void StartInit()
        {
            OnGameStateChanged?.Invoke(GameState.Pause);
        }
    }
}

