using Asteroids.Data;
using System;
using UnityEngine;

namespace Asteroids.Views
{

    public class PlayerView : MonoBehaviour, IPlayerView, IInjectable<IMoveAndRotateVariant>, IInjectable<IShootVariant>
    {
        [SerializeField] private Transform[] _weaponMounts;
        private Rigidbody2D _rigidbody;
        private IMoveAndRotateVariant _move;
        private IShootVariant _weapon;

        public event Action<int> OnDamageTaken;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Inject(IMoveAndRotateVariant dependency) => _move = dependency;
        public void Inject(IShootVariant dependency) => _weapon = dependency;


        public void Move(Vector2 direction, float speed) => _move.Move(_rigidbody, direction, speed);
        public void Rotate(float axis, float speed) => _move?.Rotate(transform, axis, speed);
        public void TakeDamage(int damage) => OnDamageTaken?.Invoke(damage);

        public void Shoot(float firePower)
        {
            _weapon?.ShootFrom(_weaponMounts, firePower);
        }

        public void SetAmmo(IPool ammoPool)
        {
            _weapon.SetAmmo(ammoPool);
        }
    }
}
