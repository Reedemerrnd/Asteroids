// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PlayerInput
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ShipControl"",
            ""id"": ""4de43743-4b40-4c88-828a-57deb899ba07"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2c5ad739-4bea-4ebc-bba9-71bd14d00eff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""f97fc3cb-ec68-43c3-bbda-f88aaf9639d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FIre"",
                    ""type"": ""Button"",
                    ""id"": ""b32a6619-8e23-4f60-abf0-1dd6b6062e58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a17f130d-bef0-4ff7-ae7b-dd29a9027fac"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be0b473-db85-4d60-906e-b7225596fc32"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""FIre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2d62d10d-0242-452d-b50e-acc6c3e45c85"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b61741f-2846-4121-a799-ac96f279a260"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e77a6cab-0751-4121-be58-43a3c6a968fb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""30daaf57-b5e7-446a-b037-693154df3aa3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""179c09c3-9747-4ad8-aa6f-d3c937708311"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // ShipControl
            m_ShipControl = asset.FindActionMap("ShipControl", throwIfNotFound: true);
            m_ShipControl_Movement = m_ShipControl.FindAction("Movement", throwIfNotFound: true);
            m_ShipControl_Rotation = m_ShipControl.FindAction("Rotation", throwIfNotFound: true);
            m_ShipControl_FIre = m_ShipControl.FindAction("FIre", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // ShipControl
        private readonly InputActionMap m_ShipControl;
        private IShipControlActions m_ShipControlActionsCallbackInterface;
        private readonly InputAction m_ShipControl_Movement;
        private readonly InputAction m_ShipControl_Rotation;
        private readonly InputAction m_ShipControl_FIre;
        public struct ShipControlActions
        {
            private @PlayerControls m_Wrapper;
            public ShipControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_ShipControl_Movement;
            public InputAction @Rotation => m_Wrapper.m_ShipControl_Rotation;
            public InputAction @FIre => m_Wrapper.m_ShipControl_FIre;
            public InputActionMap Get() { return m_Wrapper.m_ShipControl; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ShipControlActions set) { return set.Get(); }
            public void SetCallbacks(IShipControlActions instance)
            {
                if (m_Wrapper.m_ShipControlActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnMovement;
                    @Rotation.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRotation;
                    @FIre.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFIre;
                    @FIre.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFIre;
                    @FIre.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFIre;
                }
                m_Wrapper.m_ShipControlActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                    @FIre.started += instance.OnFIre;
                    @FIre.performed += instance.OnFIre;
                    @FIre.canceled += instance.OnFIre;
                }
            }
        }
        public ShipControlActions @ShipControl => new ShipControlActions(this);
        private int m_NewcontrolschemeSchemeIndex = -1;
        public InputControlScheme NewcontrolschemeScheme
        {
            get
            {
                if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
                return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
            }
        }
        public interface IShipControlActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnFIre(InputAction.CallbackContext context);
        }
    }
}
