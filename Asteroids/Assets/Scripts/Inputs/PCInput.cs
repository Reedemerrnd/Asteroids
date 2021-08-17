using System;
using UnityEngine;
using System.IO;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class PCInput : IInput
    {
        public event Action<Vector2> OnAxisChange;
        public event Action OnFire;
        private InputActionAsset _actions;

        private InputAction _mousePos;
        private InputAction _movement;
        private InputAction _fire;

        public Vector2 MousePosition => Camera.main.ScreenToWorldPoint(_mousePos.ReadValue<Vector2>());
        public Vector2 Axes => _movement.ReadValue<Vector2>();
        

        public PCInput()
        {
            var file = File.ReadAllText(@"Assets/Resources/Input/PlayerControls.inputactions");
            _actions = InputActionAsset.FromJson(file);
            _actions.Enable();
            _fire = _actions.FindAction("Fire");
            _movement = _actions.FindAction("Movement");
            _mousePos = _actions.FindAction("Rotation");
            _fire.started += (e) => OnFire?.Invoke();
        }
        
    }
}
