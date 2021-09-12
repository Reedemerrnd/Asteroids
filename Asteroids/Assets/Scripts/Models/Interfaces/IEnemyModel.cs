using Asteroids.Data;

namespace Asteroids.Models
{
    public interface IEnemyModel : IMoveModel, IDoDamage
    {
        public EnemyType enemyType { get; }
        public int Health { get; }
        public int Score { get; }
    }
}
