namespace Asteroids.Views
{
    public sealed class Bullet : BaseAmunition
    {
        public override void Interaction()
        {
            Deactivate();
        }
    }
}
