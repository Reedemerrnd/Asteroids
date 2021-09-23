using Asteroids.Core;
using Asteroids.Data;
using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Controller
{
    internal class EnemySpawnController : IController, IAwakeInitialize, IExecute
    {
        private IPoolSet<EnemyType> _enemyPool;
        private IEnemyModelSet _enemyModels;
        private IEnemySpawnModel _spawnModel;
        private readonly IVisitMediator<IEnemy> _mediator;
        private float _time;



        public EnemySpawnController(IPoolSet<EnemyType> enemyPool, IEnemyModelSet enemyModels, IEnemySpawnModel spawnModel, IVisitMediator<IEnemy> mediator)
        {
            _enemyPool = enemyPool;
            _enemyModels = enemyModels;
            _spawnModel = spawnModel;
            _mediator = mediator;
        }

        private void LaunchEnemy(EnemyType type)
        {
            _enemyPool.TryGetItem(type, out var enemy);
            var position = _spawnModel.GetSpawnPoint();

            var enemyView = enemy.GetComponent<IEnemy>();
            enemyView.Health = _enemyModels[enemyView.Type].Health;
            enemyView.SetDamage(_enemyModels[type].Damage);
            enemy.transform.position = position;

            enemyView.Launch(Vector2.down, _enemyModels[type].Speed);

            _mediator.Activate(enemyView);
        }

        private void SpawnEnemy()
        {
            var keys = _enemyModels.Keys;
            var random = Mathf.RoundToInt(Random.Range(0, keys.Length ));
            LaunchEnemy(keys[random]);
        }

        public void AwakeInit() => _time = Time.time;
        public void Execute()
        {
            var delay = Random.Range(_spawnModel.MinDelay, _spawnModel.MaxDelay);
            if (_time + delay <= Time.time)
            {
                for (int i = 0; i < 2; i++)
                {
                    SpawnEnemy();
                }
                _time = Time.time;
            }
        }
    }
}
