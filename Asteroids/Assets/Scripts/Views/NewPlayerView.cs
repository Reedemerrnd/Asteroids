using System;
using UnityEngine;

namespace Asteroids.Views
{
    public sealed class NewPlayerView : MonoBehaviour, IShip
    {
        [SerializeField] private Transform[] _barrels;

        private Rigidbody2D _rigidbody;

        public event Action<int> OnDamageTaken;
        public Transform[] Barrels => _barrels;
        public Rigidbody2D MoveComponent
        {
            get
            {
                if (_rigidbody == null)
                {
                    TryGetComponent<Rigidbody2D>(out _rigidbody);
                }
                return _rigidbody;
            }
        }

        public void TakeDamage(int damage)
        {
            OnDamageTaken?.Invoke(damage);
        }
    }
}
