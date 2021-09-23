using Asteroids.Core.States;

namespace Asteroids.Views
{
    internal interface IShip : IHaveWeapons, ITakeEnemyDamage, IInputMove, IInputRotate, ITeleport
    {
        public void SetState(IShipState state);
        public ShipStates State { get; }
    }
}
