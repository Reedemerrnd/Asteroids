using Asteroids.Core.States;
using Asteroids.Models;
using Asteroids.Views;
using UnityEngine;

namespace Controller
{
    internal sealed class ShipStateController : IController, IStartInitialize, IDisable
    {
        private readonly IShip _view;
        private readonly IShipModel _model;
        private readonly IShipStateHandler _stateHandler;

        public ShipStateController(IShip view, IShipModel model, IShipStateHandler stateHandler)
        {
            _view = view;
            _model = model;
            _stateHandler = stateHandler;
        }

        public void StartInit()
        {
            _view.SetState(_stateHandler.GetState(ShipStates.Normal));
            _model.Health.OnMediumHarm += HealthOnMediumHarm;
            _model.Health.OnHeavyHarm += HealthOnHeavyHarm;
            Debug.Log(_view.State);
        }

        private void HealthOnHeavyHarm()
        {
            _view.SetState(_stateHandler.GetState(ShipStates.HeavylyDamaged));
            Debug.Log(_view.State);
        }

        private void HealthOnMediumHarm()
        {
            _view.SetState(_stateHandler.GetState(ShipStates.Damaged));
            Debug.Log(_view.State);
        }

        public void Disable()
        {
            _model.Health.OnMediumHarm -= HealthOnMediumHarm;
            _model.Health.OnHeavyHarm -= HealthOnHeavyHarm;
        }
    }
}
