

using Asteroids.Views;

namespace Asteroids.Data

{
    internal interface IUILoader
    {
        public BaseUI LoadInGameUI();
        public BaseUI LoadMainMenu();
    }
}
