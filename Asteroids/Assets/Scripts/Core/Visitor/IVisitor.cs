using Asteroids.Views;

namespace Asteroids.Core
{
    internal interface IVisitor
    {
        public void Visit(IEnemy enemy);
    }
}
