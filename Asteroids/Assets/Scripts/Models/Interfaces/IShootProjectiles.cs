namespace Asteroids.Models
{
    public interface IShootProjectiles
    {
        public bool CanShoot();
        public float FirePower { get; }
    }
}
