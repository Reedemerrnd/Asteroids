using System.Collections;

namespace Asteroids.Models
{
    internal interface IShipModel : ICanMoveAndRotate, ICanShoot, IHaveHealth, IAbilityEnumerator
    {
        public float Speed { get; }
        public void AddSpeed(float speed);
        public float RotationSpeed { get; }

    }
}
