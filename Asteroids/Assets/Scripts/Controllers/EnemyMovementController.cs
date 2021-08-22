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
    public class EnemyMovementController : IController, IInitialize, IExecute
    {
        private IPoolSet<EnemyType> _enemyPool;
        private IEnemyModelSet _enemyModels;
        private IEnemySpawnModel _spawnModel;
        private float _time;



        public EnemyMovementController(IPoolSet<EnemyType> enemyPool, IEnemyModelSet enemyModels, IEnemySpawnModel spawnModel)
        {
            _enemyPool = enemyPool;
            _enemyModels = enemyModels;
            _spawnModel = spawnModel;
        }

        private void LaunchEnemy(EnemyType type)
        {
            _enemyPool.TryGetItem(type, out var enemy);
            var position = _spawnModel.GetSpawnPoint();
            enemy.transform.position = position;
            enemy.GetComponent<IMove>().Move(AxisManager.POSITIVE, _enemyModels[type].Speed);
        }

        private void SpawnEnemy()
        {
            var keys = _enemyModels.Keys;
            var random = Mathf.RoundToInt(Randomize(0, keys.Length));
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
                _time = Time.time;
            }
        }
    }
}
