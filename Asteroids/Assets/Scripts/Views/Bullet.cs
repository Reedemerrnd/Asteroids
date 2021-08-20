using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class Bullet : MonoBehaviour, IBullet
    {
        public void Fire(Vector3 direction, float power = 100)
        {
            TryGetComponent<Rigidbody2D>(out var rigidbody);
            rigidbody.AddForce(direction * power);
        }
    }
}
