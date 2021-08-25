using UnityEngine;

namespace Asteroids.Views
{
    internal sealed class Bullet : BaseAmunition, IPlayerProjectile
    {
        private int _damage;

        public void SetDamage(int damage) => _damage = damage;

        protected override void Interaction(Collider2D other)
        {
            other.gameObject.TryGetComponent<ITakeDamage>(out var enemy);
            enemy.TakeDamage(_damage);
            Deactivate();
        }
    }
}
