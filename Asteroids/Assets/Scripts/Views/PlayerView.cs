using System;
using UnityEngine;

namespace Asteroids.Views
{

    public class PlayerView : BaseRigidbodyMovingObject, IPlayerView
    {

        [SerializeField] private Transform[] _weaponMounts;
        public Transform[] MuzzlesTransform => _weaponMounts;

        public event Action<int> OnDamageTaken;

        public void SetRotation(float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));
        public void TakeDamage(int damage) => OnDamageTaken?.Invoke(damage);
    }
}
