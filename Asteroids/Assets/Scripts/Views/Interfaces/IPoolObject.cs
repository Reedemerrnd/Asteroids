using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public interface IPoolObject
    {
        public GameObject GameObj { get; }
        public IPoolObject Activate(float lifeTime);
        public IPool Pool { set; }
    }
}
