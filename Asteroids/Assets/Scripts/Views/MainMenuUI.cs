using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Asteroids.Views
{
    public sealed class MainMenuUI : BaseUI, IMainMenu
    {
        [SerializeField] private Button _starButton;
        [SerializeField] private Button _exitButton;


        public override void Cancel() => gameObject.SetActive(false);
        public override void Execute() => gameObject.SetActive(true);


        public void StartSubscribe(UnityAction subscriber)
        {
            _starButton.onClick.AddListener(subscriber);
        }
        public void ExitSubscribe(UnityAction subscriber)
        {
            _exitButton.onClick.AddListener(subscriber);
        }


        private void OnDisable()
        {
            _starButton.onClick.RemoveAllListeners();
            _exitButton.onClick.RemoveAllListeners();
        }
    }
}
