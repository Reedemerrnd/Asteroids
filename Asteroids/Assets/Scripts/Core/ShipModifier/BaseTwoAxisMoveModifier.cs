using Asteroids.Models;

namespace Asteroids.Data
{
    internal class BaseTwoAxisMoveModifier : ShipModifier
    {
        public BaseTwoAxisMoveModifier(IShipModel ship) : base(ship)
        {
        }
        public override void Handle()
        {
            _ship.Inject(new TwoAxisMoveAndRotate());
            base.Handle();
        }
    }
}
