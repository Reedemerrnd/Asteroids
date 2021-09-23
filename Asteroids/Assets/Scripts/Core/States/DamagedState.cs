using Asteroids.Views;

namespace Asteroids.Core.States
{
    public sealed class DamagedState : ShipState
    {
        public DamagedState(IMoveAndRotateVariant movement) : base(movement)
        {
            _state = ShipStates.Damaged;
        }
    }
}
