using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public interface IPoolObject
    {
        public GameObject GameObj { get; }
        public int LifeTime { get; }
        public IPoolObject Activate();
        public IPool Pool { set; }
    }
}
