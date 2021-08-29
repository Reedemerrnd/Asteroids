using System;
using UnityEngine;

namespace Asteroids.Views
{

    public class PlayerView : MonoBehaviour, IPlayerView, IInjectable<IMoveAndRotateVariant>
    {
        [SerializeField] private Transform[] _weaponMounts;
        private Rigidbody2D _rigidbody;
        private IMoveAndRotateVariant _move;
        public Transform[] MuzzlesTransform => _weaponMounts;

        public event Action<int> OnDamageTaken;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Inject(IMoveAndRotateVariant dependency)
        {
            _move = dependency;
        }


        public void Move(Vector2 direction, float speed) => _move.Move(_rigidbody, direction, speed);
        public void Rotate(float axis, float speed) => _move?.Rotate(transform, axis, speed);
        public void TakeDamage(int damage) => OnDamageTaken?.Invoke(damage);
    }
}
