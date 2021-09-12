using Asteroids.Models;
using Asteroids.Views;
using Inputs;

namespace Controller
{
    class PlayerMovementController : IController, IFixedExecute, IExecute
    {
        private readonly IShip _playerView;
        private readonly IInput _input;
        private readonly IShipModel _playerModel;

        public PlayerMovementController(IShip playerView, IInput input, IShipModel playerModel)
        {
            _playerView = playerView;
            _input = input;
            _playerModel = playerModel;
        }

        public void FixedExecute()
        {
            _playerModel.Movement.Move(_playerView.MoveComponent, _input.Thrust, _playerModel.Speed);
        }

        public void Execute()
        {
            _playerModel.Movement.Rotate(_playerView.MoveComponent.transform, _input.Rotation, _playerModel.RotationSpeed);
        }
    }
}
