using UnityEngine;

namespace Asteroids.Views
{
    public class OneAxisMoveAndRotate: OneAxisMove, IMoveAndRotateVariant
    {
        public virtual void Rotate(Transform transform, float axis, float speed) => transform.Rotate(new Vector3(0, 0, Mathf.Clamp(axis, -1f,1f) * speed));
    }

}
