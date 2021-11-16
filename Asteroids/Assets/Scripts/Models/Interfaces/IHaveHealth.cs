using Asteroids.Views;
using System;

namespace Asteroids.Models
{
    internal interface IHaveHealth : IInjectable<IHealthModel>
    {
        public IHealthModel Health { get; }
    }
}
