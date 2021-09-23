using Asteroids.Data;
using Asteroids.Models;
using Asteroids.Views;
using System;

namespace Asteroids.Core
{
    internal sealed class EnemyDeathObserver : IObserver<EnemyDeathInfo>, IVisitor
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

        public void Visit(IEnemy enemy)
        {
            enemy.SubscribeOnDeath(EnemyDeathHandler);
        }
    }
}
