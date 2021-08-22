using System;
using UnityEngine;

namespace Asteroids.Data
{

    public abstract class BaseFlyingObject : BaseObject
    {
        [SerializeField] protected float _speed;
    }
}
