using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using UnityEngine;
using View;
using Inputs;

namespace Controller
{
    class PlayerMovementController : IController, IFixedExecute, IExecute
    {
        private IFullMove _playerView;
        private IInput _input;

        public PlayerMovementController(IFullMove playerView, IInput input)
        {
            _playerView = playerView;
            _input = input;
        }

        public void FixedExecute()
        {
            _playerView.Move(_input.Axes * 10f);
        }

        public void Execute()
        {
            _playerView.SetLook(_input.MousePosition);
        }
    }
}
