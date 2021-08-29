using System;

namespace Asteroids.Views
{
    public interface IHealth
    {
        public event Action OnDeath;
        public void TakeDamage(int damage);
        public void SetHealth(int health);
    }
}
