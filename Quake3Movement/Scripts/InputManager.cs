using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance => _instance;

    private PlayerControlInput _controls;
    private bool _jumpState;

    private void OnEnable() => _controls.Enable();
    private void OnDisable() => _controls.Disable();

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;
        
        _controls = new PlayerControlInput();
        
    }

    public Vector2 OnMovePerformed()
    {
        return _controls.Gameplay.Movement.ReadValue<Vector2>();
    }

    public Vector2 OnMouseLook()
    {
        return _controls.Gameplay.Look.ReadValue<Vector2>();
    }

    public bool OnJumpTriggered()
    {
        return _controls.Gameplay.Jump.triggered;
    }

    public bool OnJumpButtonUp()
    {
        if (_controls.Gameplay.Jump.WasReleasedThisFrame())
        {
            _jumpState = false;
        }
        return _jumpState;
    }
    
    public bool OnJumpButtonDown()
    {
        if (_controls.Gameplay.Jump.WasPressedThisFrame())
        {
            _jumpState = true;
        }
        return _jumpState;
    }

    public bool OnEscButton()
    {
        return _controls.Gameplay.Escape.triggered;
    }

    public bool CursorLock()
    {
        return _controls.Gameplay.LeftClick.WasReleasedThisFrame();
    }
}
