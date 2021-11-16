namespace Asteroids.Core
{
    internal interface IVisitMediator<T>
    {
        public void Activate(T activator);
    }
}
