//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Input/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""MoveGrid"",
            ""id"": ""53d77562-4b48-46d7-9177-30dd18c81de7"",
            ""actions"": [
                {
                    ""name"": ""Up_Down"",
                    ""type"": ""Button"",
                    ""id"": ""a670c74b-b536-4de0-afdc-cd72dd82fb55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left_Right"",
                    ""type"": ""Button"",
                    ""id"": ""c0f8977d-8add-4951-ae65-a75314cf06a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""b276f259-f0f5-4f72-95b2-d623e3577d9e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up_Down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""54f04268-64c1-43ed-9aeb-86e42c613473"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""ecd8314b-2cf7-4f83-9ffb-0261d8dff982"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left/Right"",
                    ""id"": ""f002d948-8db5-4904-8161-e12df428a61e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5e5cf9cd-8342-4631-a862-805a821762fb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bcbd6f92-7890-44e9-9ffd-e980cc04bf95"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveGrid
        m_MoveGrid = asset.FindActionMap("MoveGrid", throwIfNotFound: true);
        m_MoveGrid_Up_Down = m_MoveGrid.FindAction("Up_Down", throwIfNotFound: true);
        m_MoveGrid_Left_Right = m_MoveGrid.FindAction("Left_Right", throwIfNotFound: true);
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

    // MoveGrid
    private readonly InputActionMap m_MoveGrid;
    private List<IMoveGridActions> m_MoveGridActionsCallbackInterfaces = new List<IMoveGridActions>();
    private readonly InputAction m_MoveGrid_Up_Down;
    private readonly InputAction m_MoveGrid_Left_Right;
    public struct MoveGridActions
    {
        private @PlayerInput m_Wrapper;
        public MoveGridActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up_Down => m_Wrapper.m_MoveGrid_Up_Down;
        public InputAction @Left_Right => m_Wrapper.m_MoveGrid_Left_Right;
        public InputActionMap Get() { return m_Wrapper.m_MoveGrid; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveGridActions set) { return set.Get(); }
        public void AddCallbacks(IMoveGridActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveGridActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveGridActionsCallbackInterfaces.Add(instance);
            @Up_Down.started += instance.OnUp_Down;
            @Up_Down.performed += instance.OnUp_Down;
            @Up_Down.canceled += instance.OnUp_Down;
            @Left_Right.started += instance.OnLeft_Right;
            @Left_Right.performed += instance.OnLeft_Right;
            @Left_Right.canceled += instance.OnLeft_Right;
        }

        private void UnregisterCallbacks(IMoveGridActions instance)
        {
            @Up_Down.started -= instance.OnUp_Down;
            @Up_Down.performed -= instance.OnUp_Down;
            @Up_Down.canceled -= instance.OnUp_Down;
            @Left_Right.started -= instance.OnLeft_Right;
            @Left_Right.performed -= instance.OnLeft_Right;
            @Left_Right.canceled -= instance.OnLeft_Right;
        }

        public void RemoveCallbacks(IMoveGridActions instance)
        {
            if (m_Wrapper.m_MoveGridActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveGridActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveGridActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveGridActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveGridActions @MoveGrid => new MoveGridActions(this);
    public interface IMoveGridActions
    {
        void OnUp_Down(InputAction.CallbackContext context);
        void OnLeft_Right(InputAction.CallbackContext context);
    }
}