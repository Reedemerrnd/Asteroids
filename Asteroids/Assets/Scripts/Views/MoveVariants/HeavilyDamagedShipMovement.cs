using UnityEngine;

namespace Asteroids.Views
{
    public class HeavilyDamagedShipMovement : DamagedShipMovement
    {
        private readonly float _rotateSpeedMod;

        public HeavilyDamagedShipMovement(float moveSpeedMod, float rotateSpeedMod) : base(moveSpeedMod)
        {
            _rotateSpeedMod = rotateSpeedMod;
        }

        public override void Rotate(Transform transform, float axis, float speed)
        {
            base.Rotate(transform, axis, _rotateSpeedMod);
        }
    }
}
