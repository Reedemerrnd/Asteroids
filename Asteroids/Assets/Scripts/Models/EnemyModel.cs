using Asteroids.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public class EnemyModel : IEnemyModel
    {
        private EnemyType _enemyType;
        private int _maxHealth;
        private int _health;
        private int _damage;
        private float _speed;

        public event Action OnDeath;
        public int Health
        {
            get => _health;
            set
            {
                _health += value;
                if (_health <= 0)
                {
                    OnDeath?.Invoke();
                }
                else if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
            }
        }
        public float Speed => _speed; 
        public int Damage => _damage;
        public EnemyType enemyType => _enemyType;


        public EnemyModel(EnemyType enemyType, int maxHealth, int damage, float speed)
        {
            _enemyType = enemyType;
            _maxHealth = maxHealth;
            _health = _maxHealth;
            _damage = damage;
            _speed = speed;
        }

    }
}
