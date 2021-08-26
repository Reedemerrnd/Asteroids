using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Asteroids.Views
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BaseRigidbodyMovingObject : MonoBehaviour , IMove
    {
        private Rigidbody2D _rigidbody;
        private void Awake()
        {
            TryGetComponent<Rigidbody2D>(out _rigidbody);
        }

        public virtual void Move(float axis, float speed)
        {
            var forward2d = new Vector2(transform.up.x, transform.up.y);
            _rigidbody.AddForce(transform.up * axis * speed);
        }

    }
}
