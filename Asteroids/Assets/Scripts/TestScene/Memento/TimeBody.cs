using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class TimeBody : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;


        public int InstanceID => GetInstanceID();
        public Rigidbody2D Rigidbody
        {
            get
            {
                if (_rigidbody == null)
                {
                    _rigidbody = GetComponent<Rigidbody2D>();
                }
                return _rigidbody;
            }
        }

    }
}
