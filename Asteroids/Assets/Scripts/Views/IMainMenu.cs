using UnityEngine.Events;

namespace Asteroids.Views
{
    public interface IMainMenu
    {
        public void StartSubscribe(UnityAction subscriber);
        public void ExitSubscribe(UnityAction subscriber);
    }
}
