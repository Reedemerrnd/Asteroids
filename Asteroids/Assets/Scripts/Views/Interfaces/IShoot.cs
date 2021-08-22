using UnityEngine;

namespace Asteroids.Views
{
    public interface IShoot
    {
        public Transform[] MuzzlesTransform { get; }
    }
}
