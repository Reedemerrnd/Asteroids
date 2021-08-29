using UnityEngine;

namespace Asteroids.Views
{
    public interface IMoveAndRotateVariant : IMoveVariant
    {
        public void Rotate(Transform transform, float axis, float speed);
    }
}
