using System;

namespace Asteroids.Models
{
    public interface IHealthModel
    {
        public event Action OnDeath;
        public event Action<int> OnHealthChanged;
        public event Action OnMediumHarm;
        public event Action OnHeavyHarm;

        public int Health { get; }
        public void TakeDamage(int damage);
        public void ResetHealth();

    }
}
