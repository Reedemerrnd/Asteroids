using UnityEngine;

namespace Asteroids.Views
{
    internal interface IMovable<T> where T : Component
    {
        public T MoveComponent { get; }
    }
}
