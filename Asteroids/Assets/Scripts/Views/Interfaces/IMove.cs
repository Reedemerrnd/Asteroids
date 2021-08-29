using UnityEngine;

namespace Asteroids.Views
{
    public interface IMove
    {
        public void Move(Vector2 direction, float speed);
    }
}
