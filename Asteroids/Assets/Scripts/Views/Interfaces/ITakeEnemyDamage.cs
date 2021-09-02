using System;

namespace Asteroids.Views
{
    public interface ITakeEnemyDamage : ITakeDamage
    {
        public event Action<int> OnDamageTaken;
    }

}
