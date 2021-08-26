using System;
using System.Collections.Generic;
using Asteroids.Views;
using Asteroids.Models;
using Asteroids.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Controller
{
    class DamageController : IController, IInitialize, IDisable
    {
        private readonly IPlayerView _playerView;
        private readonly IPlayerModel _playerModel;

        public DamageController(IPlayerView playerView, IPlayerModel playerModel)
        {
            _playerView = playerView;
            _playerModel = playerModel;
        }

        private void ProcessPlayerDamage(int damage)
        {
            _playerModel.TakeDamage(damage);
            Debug.Log(_playerModel.Health);
        }
 
        public void Init()
        {
            _playerView.OnDamageTaken += ProcessPlayerDamage;
        }
        public void Disable()
        {
            _playerView.OnDamageTaken -= ProcessPlayerDamage;
            
        }
    }
}
