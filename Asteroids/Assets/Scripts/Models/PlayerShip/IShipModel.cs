namespace Asteroids.Models
{
    internal interface IShipModel : ICanMoveAndRotate, ICanShoot, IHaveHealth
    {
        public float Speed { get; }
        public float RotationSpeed { get; }
    }
}
