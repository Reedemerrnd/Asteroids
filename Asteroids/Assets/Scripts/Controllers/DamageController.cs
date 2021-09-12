using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Controller
{
    class DamageController : IController, IAwakeInitialize, IDisable
    {
        private readonly IShip _playerView;
        private readonly IHealthModel _playerHealthModel;

        public DamageController(IShip playerView, IHealthModel playerHealthModel)
        {
            _playerView = playerView;
            _playerHealthModel = playerHealthModel;
        }

        private void ProcessPlayerDamage(int damage)
        {
            _playerHealthModel.TakeDamage(damage);
        }

        public void AwakeInit()
        {
            _playerView.OnDamageTaken += ProcessPlayerDamage;
        }
        public void Disable()
        {
            _playerView.OnDamageTaken -= ProcessPlayerDamage;

        }
    }
}
