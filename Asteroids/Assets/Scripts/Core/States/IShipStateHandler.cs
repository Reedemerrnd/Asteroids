namespace Asteroids.Core.States
{
    public interface IShipStateHandler
    {
        public IShipState GetState(ShipStates state);
    }
}
