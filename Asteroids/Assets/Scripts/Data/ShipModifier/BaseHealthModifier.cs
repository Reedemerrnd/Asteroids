using Asteroids.Models;

namespace Asteroids.Data
{
    internal class BaseHealthModifier : ShipModifier
    {
        private int _maxHealth;
        public BaseHealthModifier(IShipModel ship, int maxHealth) : base(ship)
        {
            _maxHealth = maxHealth;
        }

        public override void Handle()
        {
            _ship.Inject(new HealthModel(_maxHealth));
            base.Handle();
        }
    }
}
