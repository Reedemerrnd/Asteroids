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
        private readonly EnemyDeathObserver _observer;
        private float _time;



        public EnemySpawnController(IPoolSet<EnemyType> enemyPool, IEnemyModelSet enemyModels, IEnemySpawnModel spawnModel, EnemyDeathObserver observer)
        {
            _enemyPool = enemyPool;
            _enemyModels = enemyModels;
            _spawnModel = spawnModel;
            _observer = observer;
        }

        private void LaunchEnemy(EnemyType type)
        {
            _enemyPool.TryGetItem(type, out var enemy);
            var position = _spawnModel.GetSpawnPoint();

            var enemyView = enemy.GetComponent<IEnemy>();
            enemyView.Health = _enemyModels[enemyView.Type].Health;
            enemyView.SetDamage(_enemyModels[type].Damage);
            enemyView.SubscribeOnDeath(_observer.EnemyDeathHandler);
            enemy.transform.position = position;
            enemyView.Launch(Vector2.down, _enemyModels[type].Speed);
        }

        private void SpawnEnemy()
        {
            var keys = _enemyModels.Keys;
            var random = Mathf.RoundToInt(Randomize(0, keys.Length - 1));
            LaunchEnemy(keys[random]);
        }

        private float Randomize(float min, float max) => UnityEngine.Random.Range(min, max);

        public void AwakeInit() => _time = Time.time;
        public void Execute()
        {
            var delay = Randomize(_spawnModel.MinDelay, _spawnModel.MaxDelay);
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
