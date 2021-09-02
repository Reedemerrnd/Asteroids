using System;

namespace Asteroids.Models
{
    class HealthModel : IHealthModel
    {
        private int _health;
        private int _maxHealth;


        public int Health => _health;

        public event Action OnDeath;


        public HealthModel(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }


        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                OnDeath?.Invoke();
            }
        }

        public void ResetHealth() => _health = _maxHealth;
    }
}
