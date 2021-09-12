using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Enemy")]
    public sealed class EnemyData : ScriptableObject
    {
        public EnemyType Type;
        public GameObject Prefab;
        public int Score;
        public int MaxHealth;
        public int Damage;
        public float Speed;
    }
}
