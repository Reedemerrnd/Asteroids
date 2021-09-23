using Asteroids.Views;

namespace Asteroids.Core.States
{
    public sealed class HeavilyDamagedState : ShipState
    {
        public HeavilyDamagedState(IMoveAndRotateVariant movement) : base(movement)
        {
            _state = ShipStates.HeavylyDamaged;
        }
    }
}
