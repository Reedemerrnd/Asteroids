using UnityEngine;

namespace Asteroids.Models
{
    public interface IMoveVariant
    {
        public void Move(Rigidbody2D moveComponent, Vector2 direction, float speed);
        public void Stop(Rigidbody2D moveComponent);
    }
}
