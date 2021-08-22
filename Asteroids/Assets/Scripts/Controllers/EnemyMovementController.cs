using System;
using Asteroids.Data;
using Asteroids.Views;
using Asteroids.Models;
using Asteroids;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

namespace Controller
{
    public class EnemyMovementController : IController, IInitialize, IExecute
    {
        private IPoolSet<EnemyType> _enemyPool;
        private Dictionary<EnemyType, IEnemyModel> _enemyModels;
        private float _maxDelay = 2f;
        private float _minDelay = 5f;
        private float _offset = 2f;
        private float _minYToSpawn;
        private float _maxYToSpawn;
        private float _maxXToSpawn;
        private float _minXToSpawn;
        private float _time;



        public EnemyMovementController(IPoolSet<EnemyType> enemyPool)
        {
            _enemyPool = enemyPool;
            _minYToSpawn = ScreenBounds.BottomLeft.y;
            _maxYToSpawn = ScreenBounds.TopLeft.y;
            _minXToSpawn = ScreenBounds.TopLeft.x;
            _maxXToSpawn = ScreenBounds.TopRight.x;
        }

        private void LaunchAsteroid()
        {
            _enemyPool.TryGetItem(EnemyType.Asteroid, out var enemy);
            var position = new Vector3(Randomize(_minXToSpawn, _maxXToSpawn), (_maxYToSpawn + _offset), 0);
            enemy.transform.position = position;
            enemy.GetComponent<IMove>().Move(AxisManager.POSITIVE, 1000f);
        }

        private float Randomize(float min, float max) => UnityEngine.Random.Range(min, max);

        public void Init() => _time = Time.time;
        public void Execute()
        {
            var delay = Randomize(_minDelay, _maxDelay);
            if(_time+delay <= Time.time)
            {
                LaunchAsteroid();
                _time = Time.time;
            }
        }
    }
}
