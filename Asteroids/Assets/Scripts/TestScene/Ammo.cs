using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Test
{
    public class Ammo : MonoBehaviour, IAmmo
    {
        private Rigidbody2D _rigidbody;

        public Rigidbody2D Rigidbody => _rigidbody;

        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

    }
}
