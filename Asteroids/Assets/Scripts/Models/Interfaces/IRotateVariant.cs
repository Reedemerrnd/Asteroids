using UnityEngine;

namespace Asteroids.Models
{
    public interface IRotateVariant
    {
        public void Rotate(Transform transform, float axis, float speed);
    }
}
