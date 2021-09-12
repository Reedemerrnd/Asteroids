using System;
using Asteroids.Data;

namespace Controller
{
    internal interface IObserver<T>
    {
        public event Action<T> OnEnemyDeath;
    }
}
