using System;
using Asteroids.Data;
using Asteroids.Views;
using Asteroids.Models;
using Asteroids;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class EnemySpawnController : IController, IInitialize, IExecute
    {
        private IPoolSet<EnemyType> _enemyPool;
        private IEnemyModelSet _enemyModels;
        private IEnemySpawnModel _spawnModel;
        private float _time;



        public EnemySpawnController(IPoolSet<EnemyType> enemyPool, IEnemyModelSet enemyModels, IEnemySpawnModel spawnModel)
        {
            _enemyPool = enemyPool;
            _enemyModels = enemyModels;
            _spawnModel = spawnModel;
        }

        private void LaunchEnemy(EnemyType type)
        {
            _enemyPool.TryGetItem(type, out var enemy);
            var position = _spawnModel.GetSpawnPoint();

            var enemyView = enemy.GetComponent<IEnemy>();
            enemyView.Health = _enemyModels[enemyView.Type].Health;
            enemyView.SetDamage(_enemyModels[type].Damage);

            enemy.transform.position = position;
            enemy.GetComponent<IMove>().Move(AxisManager.NEGATIVE, _enemyModels[type].Speed);
        }

        private void SpawnEnemy()
        {
            var keys = _enemyModels.Keys;
            var random = Mathf.RoundToInt(Randomize(0, keys.Length-1));
            LaunchEnemy(keys[random]);
        }

        private float Randomize(float min, float max) => UnityEngine.Random.Range(min, max);

        public void Init() => _time = Time.time;
        public void Execute()
        {
            var delay = Randomize(_spawnModel.MinDelay, _spawnModel.MaxDelay);
            if(_time+delay <= Time.time)
            {
                SpawnEnemy();
                SpawnEnemy();
                SpawnEnemy();
                _time = Time.time;
            }
        }
    }
}
