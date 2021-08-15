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
        public void SetLook(Vector2 point)
        {
            var target = new Vector3(point.x, point.y, 0);
            Vector3 dir = target - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }



    }
}
