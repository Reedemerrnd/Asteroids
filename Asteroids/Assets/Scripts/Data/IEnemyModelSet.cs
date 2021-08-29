using Asteroids.Data;

namespace Asteroids.Models
{
    public interface IEnemyModelSet
    {
        IEnemyModel this[EnemyType index]
        {
            get;
        }

        public int Count { get; }
        public EnemyType[] Keys { get; }


    }
}
