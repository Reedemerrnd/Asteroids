using System;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Views
{
    public sealed class InGameUIPanel : BaseUI, IInGameUI
    {
        [SerializeField] private Text _healthText;
        [SerializeField] private Text _scoreText;
        [SerializeField] private Text _logText;
        [SerializeField] private float _logClearDelay;


        public override void Cancel() => gameObject.SetActive(false);
        public override void Execute() => gameObject.SetActive(true);

        public void SetHp(string health) => _healthText.text = "Health: " + health;
        public void SetScore(string score) => _scoreText.text = "Score: " + score;
        public void ShowLog(string message)
        {
            CancelInvoke(nameof(ClearLog));
            _logText.text = message;
            Invoke(nameof(ClearLog), _logClearDelay);
        }


        private void ClearLog()
        {
            _logText.text = string.Empty;
        }
    }
}
