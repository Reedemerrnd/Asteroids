using System;
using UnityEngine;

namespace Asteroids.Views
{

    public class PlayerView : BaseRigidbodyMovingView, IPlayerView
    {
        [SerializeField] private Transform[] _weaponMounts;
        public Transform[] MuzzlesTransform => _weaponMounts;

        public void SetRotation(float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));
    }
}
