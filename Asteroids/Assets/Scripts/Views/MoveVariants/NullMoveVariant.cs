using UnityEngine;

namespace Asteroids.Views
{
    public sealed class NullMoveVariant : IMoveAndRotateVariant
    {
        public void Move(Rigidbody2D moveComponent, Vector2 direction, float speed) => Debug.LogWarning("NullMoveVarinat");

        public void Rotate(Transform transform, float axis, float speed) => Debug.LogWarning("NullMoveVarinat");

        public void Stop(Rigidbody2D moveComponent) => Debug.LogWarning("NullMoveVarinat");
    }
}
