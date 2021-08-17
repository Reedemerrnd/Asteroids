using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View
{
    public class Bullet : MonoBehaviour, IBullet
    {
        public void Fire(float power = 1)
        {
            TryGetComponent<Rigidbody2D>(out var rigidbody);
            rigidbody.AddForce(Vector2.up * power);
        }
    }
}
