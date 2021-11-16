using Asteroids.Views;

namespace Asteroids.Core.States
{
    public sealed class NormalState : ShipState
    {
        public NormalState(IMoveAndRotateVariant movement) : base(movement)
        {
            _state = ShipStates.Normal;
        }
    }
}
