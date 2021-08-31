using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Data
{
    internal sealed class ShipFactory : AbstractFactory<IShipModel, IShip>
    {
        private ShipData _data;
        private IWeaponModel _weaponModel;

        public ShipFactory(IDataLoader dataLoader) : base(dataLoader)
        {
        }

        public void SetShip(PlayerShip playerShip, IWeaponModel weapon)
        {
            _data = _dataLoader.LoadShip(playerShip);
            _weaponModel = weapon;
        }

        public override IShipModel GetModel()
        {
            var ship = new NewShipModel(_data.Speed, _data.RotationSpeed);
            ship.Inject(new HealthModel(_data.MaxHealth));
            ship.Inject(new TwoAxisMoveAndRotate());
            ship.Inject(_weaponModel);

            return ship;
        }

        public override IShip GetView()
        {
            var view = Object.Instantiate(_data.Prefab, Vector3.zero, Quaternion.identity);
            return view.GetComponent<IShip>();
        }
    }
}
