using System;
using Asteroids.Data;

namespace Asteroids.Core
{
    internal interface IObserver<T>
    {
        public event Action<T> OnEnemyDeath;
    }
}
