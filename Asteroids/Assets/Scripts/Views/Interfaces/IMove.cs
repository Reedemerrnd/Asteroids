using UnityEngine;

namespace Asteroids.Views
{
    public interface IMove
    {
        public void Move(float axis, float speed);
    }
}
