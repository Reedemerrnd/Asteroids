using UnityEngine;

namespace Asteroids.Views
{
    public class OneAxisMove : IMoveVariant
    {

        public virtual void Move(Rigidbody2D rigidbody, Vector2 direction, float speed)
        {
            rigidbody.AddForce(rigidbody.transform.up * direction.y * speed);
        }

        public virtual void Stop(Rigidbody2D rigidbody) => rigidbody.velocity = Vector2.zero;
    }
}
