using System;

namespace Asteroids.Models
{
    public interface IHealthModel
    {
        public event Action OnDeath;
        public int Health { get; }
        public void TakeDamage(int damage);
        public void ResetHealth();
        public event Action<int> OnHealthChanged;
    }
}
