using System;
using UnityEngine;

namespace Asteroids.Models
{
    internal class HealthModel : IHealthModel
    {
        private int _health;
        private readonly int _maxHealth;
        private readonly int _mediumDamageValue;
        private readonly int _heavyDamageValue;


        public int Health => _health;

        public event Action OnDeath;
        public event Action<int> OnHealthChanged;
        public event Action OnMediumHarm = () => { };
        public event Action OnHeavyHarm = () => { };

        public HealthModel(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
            _mediumDamageValue = (int)( 0.75f * _maxHealth);
            _heavyDamageValue = (int)(0.3f * _maxHealth);
            Debug.Log($"{_mediumDamageValue} + {_heavyDamageValue}");
        }


        public void TakeDamage(int damage)
        {
            _health -= damage;
            OnHealthChanged?.Invoke(Health);
            if (_health <= 0)
            {
                OnDeath?.Invoke();
            }
            else if (_health <= _heavyDamageValue)
            {
                OnHeavyHarm.Invoke();
            }
            else if (_health <= _mediumDamageValue)
            {
                OnMediumHarm.Invoke();
            }
        }

        public void ResetHealth()
        {
            _health = _maxHealth;
            OnHealthChanged?.Invoke(Health);
        }
    }
}
