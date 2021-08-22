using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public interface IPoolObject
    {
        public GameObject Self { get; }
        public int LifeTime { get; }
        public IPoolObject Activate();
        public IPool Pool { set; }
    }
}
