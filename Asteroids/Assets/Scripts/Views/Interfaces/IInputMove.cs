namespace Asteroids.Views
{
    public interface IInputMove
    {
        public void Move((float horizontal, float vertical) axes, float speed);
    }
}
