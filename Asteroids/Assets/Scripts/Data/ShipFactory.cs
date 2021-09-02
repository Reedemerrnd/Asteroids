using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Data
{
    internal sealed class ShipFactory : IFactory<IShipModel, IShip>
    {
        private ShipData _data;
        private IWeaponModel _weaponModel;
        private readonly IShipLoader _dataLoader;

        public ShipFactory(IShipLoader dataLoader)
        {
            _dataLoader = dataLoader;
        }

        public void SetShip(PlayerShip playerShip, IWeaponModel weapon)
        {
            _data = _dataLoader.LoadShip(playerShip);
            _weaponModel = weapon;
        }

        public IShipModel GetModel()
        {
            var ship = new NewShipModel(_data.Speed, _data.RotationSpeed);
            ship.Inject(new HealthModel(_data.MaxHealth));
            ship.Inject(new TwoAxisMoveAndRotate());
            ship.Inject(_weaponModel);

            return ship;
        }

        public IShip GetView()
        {
            var view = Object.Instantiate(_data.Prefab, Vector3.zero, Quaternion.identity);
            return view.GetComponent<IShip>();
        }
    }
}
