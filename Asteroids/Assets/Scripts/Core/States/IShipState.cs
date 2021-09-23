using Asteroids.Views;

namespace Asteroids.Core.States
{
    public interface IShipState
    {
        IMoveAndRotateVariant Movement { get; }
        public ShipStates State { get; }
    }
}
