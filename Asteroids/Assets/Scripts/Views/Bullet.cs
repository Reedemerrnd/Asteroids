using UnityEngine;

namespace Asteroids.Views
{
    internal sealed class Bullet : BaseAmunition, IPlayerProjectile
    {


        protected override void Interaction(Collider2D other)
        {
            if (other.gameObject.TryGetComponent<IEnemy>(out var enemy))
            {
                enemy.TakeDamage(_damage);
                Deactivate();
            }
        }
    }
}
