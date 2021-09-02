using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Ship")]
    public sealed class ShipData : ScriptableObject
    {
        public PlayerShip Type;
        public GameObject Prefab;
        public float Speed;
        public float RotationSpeed;
        public int MaxHealth;
    }
}
