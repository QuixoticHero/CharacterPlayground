//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Core/Settings/PlayerUI.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerUI : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerUI()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerUI"",
    ""maps"": [
        {
            ""name"": ""CharacterController"",
            ""id"": ""18c6f823-f599-4564-8e9e-8d2f015dd3e2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5696b574-07ae-4143-9de9-4a86c80a2019"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cf665a35-946d-4906-bc6c-c0699d291d9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""ff4e2cb5-c1ae-4180-a939-b91bc8051386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SetCharacterController"",
                    ""type"": ""Button"",
                    ""id"": ""d13297ae-1430-43e8-815b-02ade52073af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85ad75e0-33a1-49c6-b426-be377f12e937"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c0320d91-3e29-4f07-8199-d1cd1d61a3cc"",
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
                    ""id"": ""da3be6a7-c1ab-4086-be67-efbd00d31579"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61c65686-80e0-42c1-bd53-ee091d2b0ff2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ebf13625-a1c8-433d-8831-b8d0b0404d36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dfaf25bb-8e7f-497f-9136-d0f42b174227"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""14f6f907-cd8b-41c3-901a-c3b93f192f75"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b242080-0d71-419f-aaf0-752d3113c243"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec113dde-df70-4f1d-8c9f-7fefd687bddb"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""016fe1fa-4f93-44ca-af9f-0848b2a9b544"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""360fbc62-328b-481e-a307-eb20c27e876a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetCharacterController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a98e4b1-3a4a-42c9-abfa-80ad2be65efb"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetCharacterController"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraController"",
            ""id"": ""b840c5f6-1b12-4e86-90ed-d8af0166bb8f"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""b60ddf1c-013a-4357-b956-ba2148af3e40"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Distance"",
                    ""type"": ""Value"",
                    ""id"": ""f125aa5b-c55a-4181-8050-5d3180feb7a1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Scale(factor=-0.002)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""327f955a-addd-4697-87df-2976ab6842cc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f567b6c8-8c07-4dfc-a37a-5c6f4751b1c3"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffabb110-efce-43f6-9b40-677524551624"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Distance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LockCursor"",
            ""id"": ""af168875-1159-4fd4-a276-5d12cdc9c717"",
            ""actions"": [
                {
                    ""name"": ""Lock"",
                    ""type"": ""Button"",
                    ""id"": ""369cacba-03e5-476d-91b6-254749793163"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66fb40d3-7c14-4984-ac3c-f9b8ad61ff49"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterController
        m_CharacterController = asset.FindActionMap("CharacterController", throwIfNotFound: true);
        m_CharacterController_Movement = m_CharacterController.FindAction("Movement", throwIfNotFound: true);
        m_CharacterController_Jump = m_CharacterController.FindAction("Jump", throwIfNotFound: true);
        m_CharacterController_Crouch = m_CharacterController.FindAction("Crouch", throwIfNotFound: true);
        m_CharacterController_SetCharacterController = m_CharacterController.FindAction("SetCharacterController", throwIfNotFound: true);
        // CameraController
        m_CameraController = asset.FindActionMap("CameraController", throwIfNotFound: true);
        m_CameraController_Rotation = m_CameraController.FindAction("Rotation", throwIfNotFound: true);
        m_CameraController_Distance = m_CameraController.FindAction("Distance", throwIfNotFound: true);
        // LockCursor
        m_LockCursor = asset.FindActionMap("LockCursor", throwIfNotFound: true);
        m_LockCursor_Lock = m_LockCursor.FindAction("Lock", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterController
    private readonly InputActionMap m_CharacterController;
    private ICharacterControllerActions m_CharacterControllerActionsCallbackInterface;
    private readonly InputAction m_CharacterController_Movement;
    private readonly InputAction m_CharacterController_Jump;
    private readonly InputAction m_CharacterController_Crouch;
    private readonly InputAction m_CharacterController_SetCharacterController;
    public struct CharacterControllerActions
    {
        private @PlayerUI m_Wrapper;
        public CharacterControllerActions(@PlayerUI wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CharacterController_Movement;
        public InputAction @Jump => m_Wrapper.m_CharacterController_Jump;
        public InputAction @Crouch => m_Wrapper.m_CharacterController_Crouch;
        public InputAction @SetCharacterController => m_Wrapper.m_CharacterController_SetCharacterController;
        public InputActionMap Get() { return m_Wrapper.m_CharacterController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControllerActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControllerActions instance)
        {
            if (m_Wrapper.m_CharacterControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnCrouch;
                @SetCharacterController.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnSetCharacterController;
                @SetCharacterController.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnSetCharacterController;
                @SetCharacterController.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnSetCharacterController;
            }
            m_Wrapper.m_CharacterControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @SetCharacterController.started += instance.OnSetCharacterController;
                @SetCharacterController.performed += instance.OnSetCharacterController;
                @SetCharacterController.canceled += instance.OnSetCharacterController;
            }
        }
    }
    public CharacterControllerActions @CharacterController => new CharacterControllerActions(this);

    // CameraController
    private readonly InputActionMap m_CameraController;
    private ICameraControllerActions m_CameraControllerActionsCallbackInterface;
    private readonly InputAction m_CameraController_Rotation;
    private readonly InputAction m_CameraController_Distance;
    public struct CameraControllerActions
    {
        private @PlayerUI m_Wrapper;
        public CameraControllerActions(@PlayerUI wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_CameraController_Rotation;
        public InputAction @Distance => m_Wrapper.m_CameraController_Distance;
        public InputActionMap Get() { return m_Wrapper.m_CameraController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraControllerActions set) { return set.Get(); }
        public void SetCallbacks(ICameraControllerActions instance)
        {
            if (m_Wrapper.m_CameraControllerActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnRotation;
                @Distance.started -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnDistance;
                @Distance.performed -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnDistance;
                @Distance.canceled -= m_Wrapper.m_CameraControllerActionsCallbackInterface.OnDistance;
            }
            m_Wrapper.m_CameraControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Distance.started += instance.OnDistance;
                @Distance.performed += instance.OnDistance;
                @Distance.canceled += instance.OnDistance;
            }
        }
    }
    public CameraControllerActions @CameraController => new CameraControllerActions(this);

    // LockCursor
    private readonly InputActionMap m_LockCursor;
    private ILockCursorActions m_LockCursorActionsCallbackInterface;
    private readonly InputAction m_LockCursor_Lock;
    public struct LockCursorActions
    {
        private @PlayerUI m_Wrapper;
        public LockCursorActions(@PlayerUI wrapper) { m_Wrapper = wrapper; }
        public InputAction @Lock => m_Wrapper.m_LockCursor_Lock;
        public InputActionMap Get() { return m_Wrapper.m_LockCursor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LockCursorActions set) { return set.Get(); }
        public void SetCallbacks(ILockCursorActions instance)
        {
            if (m_Wrapper.m_LockCursorActionsCallbackInterface != null)
            {
                @Lock.started -= m_Wrapper.m_LockCursorActionsCallbackInterface.OnLock;
                @Lock.performed -= m_Wrapper.m_LockCursorActionsCallbackInterface.OnLock;
                @Lock.canceled -= m_Wrapper.m_LockCursorActionsCallbackInterface.OnLock;
            }
            m_Wrapper.m_LockCursorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Lock.started += instance.OnLock;
                @Lock.performed += instance.OnLock;
                @Lock.canceled += instance.OnLock;
            }
        }
    }
    public LockCursorActions @LockCursor => new LockCursorActions(this);
    public interface ICharacterControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSetCharacterController(InputAction.CallbackContext context);
    }
    public interface ICameraControllerActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnDistance(InputAction.CallbackContext context);
    }
    public interface ILockCursorActions
    {
        void OnLock(InputAction.CallbackContext context);
    }
}
