using UnityEngine;

namespace Asteroids.Views
{
    public interface IRotateVariant
    {
        public void Rotate(Transform transform, float axis, float speed);
    }
}
