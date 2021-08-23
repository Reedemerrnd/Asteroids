using System;
using UnityEngine;

namespace Asteroids.Views
{

    public class PlayerView : BaseRigidbodyMovingView, IPlayerView
    {
        public event Action<GameObject, int> OnDamageTaken;

        [SerializeField] private Transform[] _weaponMounts;
        public Transform[] MuzzlesTransform => _weaponMounts;

        public void SetRotation(float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));

        public void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Hit");
            if(collision.gameObject.TryGetComponent<IEnemy>(out var damager))
            {
                OnDamageTaken?.Invoke(collision.gameObject, 0);
            }
        }

    }
}
