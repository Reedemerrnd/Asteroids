using System;
using UnityEngine;
using System.IO;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class PCInput : IInput, IDisposable
    {
        private InputActionAsset _actions;

        private InputAction _rotation;
        private InputAction _controls;
        private InputAction _thrust;
        private InputAction _fire;
        private InputAction _abilityOne;
        private InputAction _abilityTwo;


        public float Rotation => _rotation.ReadValue<float>();
        public (float, float) Thrust => GetThrust();
        public bool FireHold => _fire.ReadValue<float>() > 0;
        public event Action OnLockPressed;
        public event Action OnAbilityOne;
        public event Action OnAbilityTwo;

        public PCInput()
        {
            var file = File.ReadAllText(@"Assets/Resources/Input/PlayerControls.inputactions");
            _actions = InputActionAsset.FromJson(file);
            _actions.Enable();
            _fire = _actions.FindAction("Fire");
            _thrust = _actions.FindAction("Thrust");
            _rotation = _actions.FindAction("Rotation");
            _controls = _actions.FindAction("Controls");
            _abilityOne = _actions.FindAction("AbilityOne");
            _abilityTwo = _actions.FindAction("AbilityTwo");

            _controls.performed += LockPressed;
            _abilityOne.performed += AbilityOne_performed;
            _abilityTwo.performed += AbilityTwo_performed;
        }

        private void AbilityTwo_performed(InputAction.CallbackContext obj) => OnAbilityTwo?.Invoke();
        private void AbilityOne_performed(InputAction.CallbackContext obj) => OnAbilityOne?.Invoke();

        private void LockPressed(InputAction.CallbackContext ctx)
        {
            OnLockPressed?.Invoke();
        }

        public (float, float) GetThrust()
        {
            var vector = _thrust.ReadValue<Vector2>();
            return (vector.x, vector.y);
        }

        public void Dispose()
        {
            _controls.performed -= LockPressed;
            _abilityOne.performed -= AbilityOne_performed;
            _abilityTwo.performed -= AbilityTwo_performed;
        }
    }
}
