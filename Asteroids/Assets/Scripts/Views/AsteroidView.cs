using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    internal class AsteroidView : PoolObject, ITakeDamage, IEnemy
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
                    Deactivate();
                }
                else
                {
                    _health = value;
                }
            }
        }
 
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}

