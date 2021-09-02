using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public interface IPoolObjectPrototype
    {
        public GameObject Clone();
        public GameObject GameObj { get; }
        public IPoolObjectPrototype Activate(float lifeTime);
        public IPool Pool { set; }
    }
}
