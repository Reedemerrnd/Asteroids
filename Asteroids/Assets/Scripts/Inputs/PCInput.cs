using System;
using UnityEngine;
using System.IO;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class PCInput : IInput
    {
        public event Action OnFire;
        private InputActionAsset _actions;

        private InputAction _rotation;
        private InputAction _thrust;
        private InputAction _fire;

        public float Rotation => _rotation.ReadValue<float>();
        public Vector2 Thrust => _thrust.ReadValue<Vector2>();
        

        public PCInput()
        {
            var file = File.ReadAllText(@"Assets/Resources/Input/PlayerControls.inputactions");
            _actions = InputActionAsset.FromJson(file);
            _actions.Enable();
            _fire = _actions.FindAction("Fire");
            _thrust = _actions.FindAction("Thrust");
            _rotation = _actions.FindAction("Rotation");
            _fire.started += Fire;
        }

        private void Fire(InputAction.CallbackContext context)
        {
            OnFire?.Invoke();
        }
        
    }
}
