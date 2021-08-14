using System;
using UnityEngine;

namespace View
{
    [RequireComponent(typeof(Rigidbody2D)),RequireComponent(typeof(BoxCollider2D))]
    public class PlayerView : MonoBehaviour, IPlayerVIew
    {
        [SerializeField] Transform[] _weaponMounts;
        private Rigidbody2D _rigidbody;
        public Transform[] MuzzlesTransform => _weaponMounts;
        public event Action<Collider2D> OnColliderInteraction;

        private void Start()
        {
            TryGetComponent<Rigidbody2D>(out _rigidbody);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnColliderInteraction?.Invoke(collision);
        }

        public void Move(Vector2 direction) => _rigidbody.AddForce(direction);
        public void Rotate(Vector2 rotation) => transform.Rotate(rotation, Space.Self);



    }
}