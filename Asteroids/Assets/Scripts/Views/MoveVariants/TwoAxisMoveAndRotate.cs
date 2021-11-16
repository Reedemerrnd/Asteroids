using UnityEngine;

namespace Asteroids.Views
{
    public class TwoAxisMoveAndRotate : OneAxisMoveAndRotate, IMoveAndRotateVariant
    {
        public override void Move(Rigidbody2D rigidbody, Vector2 direction, float speed)
        {
            base.Move(rigidbody, direction, speed);
            rigidbody.AddForce(rigidbody.transform.right * direction.x * speed);
        }
    }
}
