using Asteroids.Models;

namespace Asteroids.Data
{
    internal class ShipModifier
    {
        protected IShipModel _ship;
        protected ShipModifier _next;


        public ShipModifier(IShipModel ship) => _ship = ship;


        public void Add(ShipModifier shipModifier)
        {
            if (_next != null)
            {
                _next.Add(shipModifier);
            }
            else
            {
                _next = shipModifier;
            }
        }

        public virtual void Handle() => _next?.Handle();
    }
}
