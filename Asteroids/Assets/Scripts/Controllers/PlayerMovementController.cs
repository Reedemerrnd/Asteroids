using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using UnityEngine;
using Asteroids.Views;
using Inputs;
using Asteroids.Models;

namespace Controller
{
    class PlayerMovementController : IController, IFixedExecute, IExecute
    {
        private readonly IMoveAndRotate _playerView;
        private readonly IInput _input;
        private readonly IFullMoveModel _playerModel;

        public PlayerMovementController(IMoveAndRotate playerView, IInput input, IFullMoveModel playerModel)
        {
            _playerView = playerView;
            _input = input;
            _playerModel = playerModel;
        }

        public void FixedExecute()
        {
            _playerView.Move(_input.Thrust, _playerModel.Speed);
            Debug.Log(_input.Thrust);
        }

        public void Execute()
        {
            _playerView.Rotate(_input.Rotation, _playerModel.RotationSpeed);
        }
    }
}
