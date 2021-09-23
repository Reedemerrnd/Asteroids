using Asteroids.Views;

namespace Asteroids.Core.States
{
    public sealed class NoneState : ShipState
    {
        public NoneState(IMoveAndRotateVariant movement) : base(movement)
        {
            _state = ShipStates.None;           
        }
    }
}
