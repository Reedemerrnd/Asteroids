using Asteroids.Core.States;
using System;
using UnityEngine;

namespace Asteroids.Views
{
    public sealed class NewPlayerView : MonoBehaviour, IShip
    {
        [SerializeField] private Transform[] _barrels;

        private Rigidbody2D _rigidbody;
        private IShipState _state;

        public event Action<int> OnDamageTaken;
        public Transform[] Barrels => _barrels;

        public ShipStates State => _state.State;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }


        public void TakeDamage(int damage)
        {
            OnDamageTaken?.Invoke(damage);
        }

        public void Move((float horizontal, float vertical) axes, float speed)
        {
            _state.Movement.Move(_rigidbody, new Vector2(axes.horizontal, axes.vertical), speed);
        }

        public void Rotate(float axis, float speed)
        {
            _state.Movement.Rotate(transform, axis, speed);
        }

        public void SetState(IShipState state)
        {
            _state = state;
        }

        public void Teleport(Vector3 position)
        {
            transform.position = position;
        }
    }
}
