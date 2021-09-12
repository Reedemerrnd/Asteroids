using System;

namespace Asteroids.Models
{
    internal class HealthModel : IHealthModel
    {
        private int _health;
        private int _maxHealth;


        public int Health => _health;

        public event Action OnDeath;
        public event Action<int> OnHealthChanged;

        public HealthModel(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }


        public void TakeDamage(int damage)
        {
            _health -= damage;
            OnHealthChanged?.Invoke(Health);
            if (_health <= 0)
            {
                OnDeath?.Invoke();
            }
        }

        public void ResetHealth()
        {
            _health = _maxHealth;
            OnHealthChanged?.Invoke(Health);
        }
    }
}
