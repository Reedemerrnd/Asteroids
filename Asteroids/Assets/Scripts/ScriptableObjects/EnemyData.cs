using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Asteroids.Data;
using UnityEngine;
using System.Threading.Tasks;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Enemy")]
    public sealed class EnemyData : BaseFlyingObject, IEnemyData
    {
        [SerializeField] private EnemyType _type;
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _damage;

        public EnemyType Type => _type;
        public GameObject Prefab => _prefab;
        public int MaxHealth => _maxHealth;
        public int Damage => _damage;
        public float Speed => _speed;
    }
}
