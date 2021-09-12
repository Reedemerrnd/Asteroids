using Asteroids.Data;
using Asteroids.Models;
using System;

namespace Controller
{
    class EnemyDeathObserver : IObserver<EnemyDeathInfo>
    {
        private readonly IEnemyModelSet _enemyModelSet;

        public event Action<EnemyDeathInfo> OnEnemyDeath;


        public EnemyDeathObserver(IEnemyModelSet enemyModelSet)
        {
            _enemyModelSet = enemyModelSet;
        }


        public void EnemyDeathHandler(EnemyType type)
        {
            OnEnemyDeath?.Invoke(new EnemyDeathInfo(type, _enemyModelSet[type].Score));
        }

    }
}
