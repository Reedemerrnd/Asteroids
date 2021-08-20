using System;
using UnityEngine;

namespace View
{
    [RequireComponent(typeof(Rigidbody2D)),RequireComponent(typeof(BoxCollider2D))]
    public class PlayerView : MonoBehaviour, IPlayerVIew
    {
        public event Action<Collider2D> OnColliderInteraction;

        [SerializeField] Transform[] _weaponMounts;

        private Rigidbody2D _rigidbody;
        public Transform[] MuzzlesTransform => _weaponMounts;


        private void Start()
        {
            TryGetComponent<Rigidbody2D>(out _rigidbody);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnColliderInteraction?.Invoke(collision);
        }

        public void Move(float axis, float speed)
        {
            var forward2d = new Vector2(transform.right.x, transform.right.y);
            _rigidbody.AddForce(forward2d * axis * speed);
        }

        public void SetRotation(float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));




    }
}
