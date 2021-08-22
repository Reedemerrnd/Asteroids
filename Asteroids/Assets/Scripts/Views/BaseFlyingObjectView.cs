using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Asteroids.Views
{
    [RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(Collider2D))]
    public abstract class BaseFlyingObjectView : MonoBehaviour , IMove, IColliderInteraction
    {
        private Rigidbody2D _rigidbody;
        private void Awake()
        {
            TryGetComponent<Rigidbody2D>(out _rigidbody);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Interaction();
        }

        public virtual void Move(float axis, float speed)
        {
            var forward2d = new Vector2(transform.right.x, transform.right.y);
            _rigidbody.AddForce(forward2d * axis * speed);
        }
        public abstract void Interaction();

    }
}
