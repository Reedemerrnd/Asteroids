using Asteroids.Views;

namespace Asteroids.Core
{
    internal sealed class EnemySpawnVisitMediator : IVisitMediator<IEnemy>
    {
        private readonly IVisitor[] _visitors;

        public EnemySpawnVisitMediator(params IVisitor[] visitors)
        {
            _visitors = visitors;
        }
        public void Activate(IEnemy activator)
        {
            foreach (var visitor in _visitors)
            {
                activator.Activate(visitor);
            }
        }
    }
}
