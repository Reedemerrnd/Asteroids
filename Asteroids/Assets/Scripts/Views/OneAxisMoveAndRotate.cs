using UnityEngine;

namespace Asteroids.Views
{
    public class OneAxisMoveAndRotate: OneAxisMove, IMoveAndRotateVariant
    {
        public void Rotate(Transform transform, float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));
    }
    public class TwoAxisMoveAndRotate : OneAxisMove, IMoveAndRotateVariant
    {
        public override void Move(Rigidbody2D rigidbody, Vector2 direction, float speed)
        {
            base.Move(rigidbody,direction,speed);
            rigidbody.AddForce(rigidbody.transform.right * direction.x * speed);
        }

        public void Rotate(Transform transform, float axis, float speed) => transform.Rotate(new Vector3(0, 0, axis * speed));
    }
}
