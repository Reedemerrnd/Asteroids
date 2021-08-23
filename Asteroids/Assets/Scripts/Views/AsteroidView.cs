using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public class AsteroidView : InteractiveObject, ITakeDamage, IEnemy
    {
        [SerializeField] private EnemyType _type;
        private int _health;

        public EnemyType Type => _type; 
        public int Health
        {
            get => _health;
            set
            {
                if (value <= 0)
                {
                    Destroy();
                }
                else
                {
                    _health = value;
                }
            }
        }
        public event Action<GameObject, int> OnDamageTaken;
        protected override void Interaction(Collider2D other)
        {
            if (TryGetComponent<IPlayerProjectile>(out var projectile))
            {
                TakeDamage(projectile.Damage);
            }
        }
        private void TakeDamage(int damage)
        {
            OnDamageTaken?.Invoke(gameObject, damage);
        }

    }
}

