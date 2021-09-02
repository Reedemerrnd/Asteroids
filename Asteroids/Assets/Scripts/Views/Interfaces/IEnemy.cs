using Asteroids.Data;
using Asteroids.Models;

namespace Asteroids.Views
{
    internal interface IEnemy : IEnemyHealth, ITakeDamage, IProjectile, IInjectable<IMoveVariant>
    {
        public EnemyType Type { get; }
    }
}
