using Asteroids.Models;
using Asteroids.Views;

namespace Asteroids.Core.States
{
    public abstract class ShipState : IShipState
    {
        private readonly IMoveAndRotateVariant _movement;
        protected ShipStates _state = ShipStates.None;

        public IMoveAndRotateVariant Movement => _movement;

        public ShipStates State => _state;

        public ShipState(IMoveAndRotateVariant movement)
        {
            _movement = movement;
        }
    }
}
