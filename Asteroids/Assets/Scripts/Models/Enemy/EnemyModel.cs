using Asteroids.Data;
using System;

namespace Asteroids.Models
{
    public class EnemyModel : IEnemyModel
    {
        private EnemyType _enemyType;
        private int _maxHealth;
        private int _health;
        private int _damage;
        private float _speed;
        private int _score;

        public event Action OnDeath;
        public int Health => _health;

        public float Speed => _speed;
        public int Damage => _damage;
        public EnemyType enemyType => _enemyType;
        public int Score => _score;


        public EnemyModel(EnemyType enemyType, int maxHealth, int damage, float speed, int score)
        {
            _enemyType = enemyType;
            _maxHealth = maxHealth;
            _health = _maxHealth;
            _damage = damage;
            _speed = speed;
            _score = score;
        }

    }
}
