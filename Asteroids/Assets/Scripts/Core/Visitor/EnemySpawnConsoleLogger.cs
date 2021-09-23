using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Core
{
    class EnemySpawnConsoleLogger : IVisitor
    {
        public void Visit(IEnemy enemy)
        {
            Debug.Log($"{enemy.Type} spawned");
        }
    }
}
