using System.Linq;

namespace Asteroids.Core.States
{
    public sealed class ShipStateHandler : IShipStateHandler
    {
        private readonly IShipState[] _shipStates;

        public ShipStateHandler(params IShipState[] shipStates)
        {
            _shipStates = shipStates;
        }
        public IShipState GetState(ShipStates state) => _shipStates.FirstOrDefault((s) => s.State == state);
    }
}
