using System;

namespace Asteroids.Models
{
    class ShipModel : IPlayerModel
    {

        private int _health;
        private int _maxHealth;



        public event Action OnDeath;
        public int Health => _health;
        public float Speed { get; }
        public float RotationSpeed { get; }


        public ShipModel(int maxHealth, float speed, float rotationSpeed)
        {
            _maxHealth = maxHealth;
            _health = _maxHealth;
            Speed = speed;
            RotationSpeed = rotationSpeed;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                OnDeath?.Invoke();
            }
        }
    }
}
