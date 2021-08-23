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
        private List<GameObject> _views;
        private readonly IEnemyModelSet _enemyModels;
        private readonly IPoolSet<EnemyType> _viewPool;
        private readonly IPlayerView _playerView;
        private readonly IPlayerModel _playerModel;

        public DamageController(IEnemyModelSet enemyModels, IPoolSet<EnemyType> viewPool, IPlayerView playerView, IPlayerModel playerModel)
        {
            _enemyModels = enemyModels;
            _viewPool = viewPool;
            _playerView = playerView;
            _playerModel = playerModel;
        }


        public void Init()
        {
            foreach (var pool in _viewPool.GetActivePools())
            {
                if(pool is IPoolItemAdded poolItemAdded)
                {
                    poolItemAdded.OnPoolElementAdded += _views.Add;
                }
            }
        }
        public void Disable()
        {
            
        }
    }
}
