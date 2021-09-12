using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Data
{
    class UIFactory
    {
        private readonly IUILoader _uiLoader;

        public UIFactory(IUILoader uiLoader)
        {
            _uiLoader = uiLoader;
        }

        public BaseUI GetInGameUI()
        {
            var ui = Object.Instantiate(_uiLoader.LoadInGameUI());
            ui.Cancel();
            return ui;
        }
        public BaseUI GetMainMenu()
        {
            var ui = Object.Instantiate(_uiLoader.LoadMainMenu());
            ui.Cancel();
            return ui;
        }
    }
}
