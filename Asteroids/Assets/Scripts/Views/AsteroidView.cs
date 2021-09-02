using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    internal class AsteroidView : PoolObject, IEnemy
    {
        [SerializeField] private EnemyType _type;
        private int _health;
        private int _damage;

        public EnemyType Type => _type; 
        public int Health
        {
            get => _health;
            set
            {
                if (value <= 0)
                {
                    Deactivate();
                }
                else
                {
                    _health = value;
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Interaction(collision);
        }
        public void SetDamage(int damage) => _damage = damage;

        private void Interaction(Collider2D other)
        {
            if (other.gameObject.TryGetComponent<IPlayerView>(out var player))
            {
                player?.TakeDamage(_damage);
                Deactivate();
            }
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}

