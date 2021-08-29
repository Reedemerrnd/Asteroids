using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Ship")]
    public sealed class ShipData : BaseFlyingObject, IShipData
    {
        [SerializeField] private PlayerShip _type;
        [SerializeField] private int _maxHealth;
        [SerializeField] private float _rotationSpeed;

        public PlayerShip Type => _type;
        public GameObject Prefab => _prefab;
        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;
        public int MaxHealth => _maxHealth;
    }
}
