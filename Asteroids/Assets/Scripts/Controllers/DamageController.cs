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

        private void ProcessEnemyDamage(GameObject obj, int damage)
        {
            if(obj.TryGetComponent<IEnemy>(out var enemyHealth))
            {
                enemyHealth.Health -= damage;
                Debug.Log($"Enemy {enemyHealth.Health}");
            }
        }
        private void ProcessPlayerDamage(GameObject obj, int damage)
        {
            if(obj.TryGetComponent<IEnemy>(out var enemy))
            {
                _playerModel.Health -= _enemyModels[enemy.Type].Damage;
                Debug.Log($"Player {_playerModel.Health}");
            }
        }
        private void Add(GameObject obj)
        {
            _views.Add(obj);
            if(obj.TryGetComponent<ITakeDamage>(out var interactable))
            {
                interactable.OnDamageTaken += ProcessEnemyDamage;
            }
        }
        public void Init()
        {
            //foreach (var pool in _viewPool.GetActivePools())
            //{
            //    if(pool is IPoolItemAdded poolItemAdded)
            //    {
            //        poolItemAdded.OnPoolEle
            //        ,mentAdded += Add;
            //    }
            //}
            _playerView.OnDamageTaken += ProcessPlayerDamage;
        }
        public void Disable()
        {
            _playerView.OnDamageTaken -= ProcessPlayerDamage;
            //foreach (var item in _views)
            //{
            //    if (item.TryGetComponent<ITakeDamage>(out var damageTaker))
            //    {
            //        damageTaker.OnDamageTaken -= ProcessEnemyDamage;
            //    }
            //}
            //foreach (var pool in _viewPool.GetActivePools())
            //{
            //    if (pool is IPoolItemAdded poolItemAdded)
            //    {
            //        poolItemAdded.OnPoolElementAdded += Add;
            //    }
            //}
        }
    }
}
