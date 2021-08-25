using UnityEngine;

namespace Asteroids.Data
{
    public interface IShipData
    {
        public PlayerShip Type { get; }
        public GameObject Prefab { get; }
        public float Speed { get; }
        public float RotationSpeed { get; }
        public int MaxHealth { get; }
    }
}
