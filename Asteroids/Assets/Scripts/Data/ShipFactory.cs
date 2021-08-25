using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Data
{
    internal sealed class ShipFactory : AbstractFactory<IPlayerModel, IPlayerView>
    {
        private IShipData _data;

        public ShipFactory(IDataLoader dataLoader) : base(dataLoader)
        {
        }

        public void SetShip(PlayerShip playerShip)
        {
            _data = _dataLoader.LoadShip(playerShip);
        }

        public override IPlayerModel GetModel() => new ShipModel(_data.MaxHealth,_data.Speed,_data.RotationSpeed);
        public override IPlayerView GetView() => GameObject.Instantiate(_data.Prefab, Vector3.zero, Quaternion.identity).GetComponent<IPlayerView>();
    }
}
