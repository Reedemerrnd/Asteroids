using System;
using UnityEngine;

namespace Asteroids.Data
{
    public interface IEnemyData
    {
        public EnemyType Type { get; }
        public GameObject Prefab { get; }
        public int MaxHealth { get; }
        public int Damage { get; }
        public float Speed { get; }

    }
}
