using Asteroids.Views;

namespace Asteroids.Models
{
    internal interface IHaveHealth : IInjectable<IHealthModel>
    {
        public IHealthModel Health { get; }
    }
}
