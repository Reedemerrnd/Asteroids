using UnityEngine;

namespace Asteroids.Views
{
    public class DamagedShipMovement : TwoAxisMoveAndRotate
    {
        private readonly float _moveSpeedMod;

        public DamagedShipMovement(float moveSpeedMod)
        {
            _moveSpeedMod = moveSpeedMod;
        }

        public override void Move(Rigidbody2D rigidbody, Vector2 direction, float speed)
        {
            base.Move(rigidbody, direction, speed* _moveSpeedMod);
        }
    }
}
