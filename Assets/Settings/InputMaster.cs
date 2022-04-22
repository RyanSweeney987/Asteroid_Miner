// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""61e7fc57-7ebb-40e6-a089-0c67e25db900"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Value"",
                    ""id"": ""b88072e2-d28a-4b3b-86f6-ed8ee611ccd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""2cc9051d-5e41-4b5b-86b3-8a777c4b5612"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stabilise"",
                    ""type"": ""Button"",
                    ""id"": ""11b650b9-af54-4dae-8859-14cf24315438"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hook"",
                    ""type"": ""Button"",
                    ""id"": ""5b3fb391-0f00-418b-9eeb-a5017e5a9be3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66580127-304c-4022-a6ed-e4d46685b423"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""eb33ccd9-8900-4223-845e-35c15358780e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""75a56c17-29cd-4615-8f55-7345fcc3ad39"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""0af66517-ec33-4c88-bebf-3a629fee20aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""60941715-048b-41f3-b4dc-cf417b8b768f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stabilise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e5a7509-61b4-4bc0-828e-8b506b3b1f5b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""General"",
            ""id"": ""2878006c-3184-4677-94a3-c38091a39878"",
            ""actions"": [
                {
                    ""name"": ""Exit Game"",
                    ""type"": ""Value"",
                    ""id"": ""c1d77a49-6b31-4319-82c9-965ad90fe024"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sell"",
                    ""type"": ""Value"",
                    ""id"": ""ebf70639-cddb-4ce3-9fb1-c05a8c9ea945"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Refuel"",
                    ""type"": ""Value"",
                    ""id"": ""2d258077-c63b-42f5-9f92-45b73f2fcecd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0c9aea7f-d2d3-4385-89ad-e36cdf157667"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de24e338-6cf1-4dad-a4b5-80ac444a1a70"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12ed0d31-ecf6-453a-a884-db0f1751680b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Refuel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Main"",
            ""bindingGroup"": ""Main"",
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
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Thrust = m_Ship.FindAction("Thrust", throwIfNotFound: true);
        m_Ship_Rotate = m_Ship.FindAction("Rotate", throwIfNotFound: true);
        m_Ship_Stabilise = m_Ship.FindAction("Stabilise", throwIfNotFound: true);
        m_Ship_Hook = m_Ship.FindAction("Hook", throwIfNotFound: true);
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_ExitGame = m_General.FindAction("Exit Game", throwIfNotFound: true);
        m_General_Sell = m_General.FindAction("Sell", throwIfNotFound: true);
        m_General_Refuel = m_General.FindAction("Refuel", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Thrust;
    private readonly InputAction m_Ship_Rotate;
    private readonly InputAction m_Ship_Stabilise;
    private readonly InputAction m_Ship_Hook;
    public struct ShipActions
    {
        private @InputMaster m_Wrapper;
        public ShipActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_Ship_Thrust;
        public InputAction @Rotate => m_Wrapper.m_Ship_Rotate;
        public InputAction @Stabilise => m_Wrapper.m_Ship_Stabilise;
        public InputAction @Hook => m_Wrapper.m_Ship_Hook;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnThrust;
                @Rotate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Stabilise.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnStabilise;
                @Stabilise.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnStabilise;
                @Stabilise.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnStabilise;
                @Hook.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnHook;
                @Hook.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnHook;
                @Hook.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnHook;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Stabilise.started += instance.OnStabilise;
                @Stabilise.performed += instance.OnStabilise;
                @Stabilise.canceled += instance.OnStabilise;
                @Hook.started += instance.OnHook;
                @Hook.performed += instance.OnHook;
                @Hook.canceled += instance.OnHook;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_ExitGame;
    private readonly InputAction m_General_Sell;
    private readonly InputAction m_General_Refuel;
    public struct GeneralActions
    {
        private @InputMaster m_Wrapper;
        public GeneralActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitGame => m_Wrapper.m_General_ExitGame;
        public InputAction @Sell => m_Wrapper.m_General_Sell;
        public InputAction @Refuel => m_Wrapper.m_General_Refuel;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @ExitGame.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitGame;
                @Sell.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSell;
                @Sell.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSell;
                @Sell.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSell;
                @Refuel.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRefuel;
                @Refuel.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRefuel;
                @Refuel.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRefuel;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
                @Sell.started += instance.OnSell;
                @Sell.performed += instance.OnSell;
                @Sell.canceled += instance.OnSell;
                @Refuel.started += instance.OnRefuel;
                @Refuel.performed += instance.OnRefuel;
                @Refuel.canceled += instance.OnRefuel;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    private int m_MainSchemeIndex = -1;
    public InputControlScheme MainScheme
    {
        get
        {
            if (m_MainSchemeIndex == -1) m_MainSchemeIndex = asset.FindControlSchemeIndex("Main");
            return asset.controlSchemes[m_MainSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnStabilise(InputAction.CallbackContext context);
        void OnHook(InputAction.CallbackContext context);
    }
    public interface IGeneralActions
    {
        void OnExitGame(InputAction.CallbackContext context);
        void OnSell(InputAction.CallbackContext context);
        void OnRefuel(InputAction.CallbackContext context);
    }
}
