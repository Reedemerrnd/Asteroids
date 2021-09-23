using Asteroids.Models;

namespace Asteroids.Data
{
    internal class WeaponModifier : ShipModifier
    {
        private IWeaponModel _weapon;
        public WeaponModifier(IShipModel ship, IWeaponModel weapon) : base(ship)
        {
            _weapon = weapon;
        }

        public override void Handle()
        {
            _ship.Inject(_weapon);
            base.Handle();
        }
    }
}
