using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    private static PlayerInputManager m_Instance;

    public static PlayerInputManager Instance => m_Instance;

    private PlayerControlInput m_Controls;
    private bool m_JumpState;

    private void OnEnable() => m_Controls.Enable();
    private void OnDisable() => m_Controls.Disable();

    private void Awake()
    {
        m_Instance = this;
        
        m_Controls = new PlayerControlInput();
        
    }

    public Vector2 OnMovePerformed()
    {
        return m_Controls.Gameplay.Movement.ReadValue<Vector2>();
    }

    public Vector2 OnMouseLook()
    {
        return m_Controls.Gameplay.Look.ReadValue<Vector2>();
    }

    public bool OnJumpTriggered()
    {
        return m_Controls.Gameplay.Jump.triggered;
    }

    public bool OnJumpButtonUp()
    {
        if (m_Controls.Gameplay.Jump.WasReleasedThisFrame())
        {
            m_JumpState = false;
        }
        return m_JumpState;
    }
    
    public bool OnJumpButtonDown()
    {
        if (m_Controls.Gameplay.Jump.WasPressedThisFrame())
        {
            m_JumpState = true;
        }
        return m_JumpState;
    }

    public bool OnEscButton()
    {
        return m_Controls.Gameplay.Escape.triggered;
    }

    public bool CursorLock()
    {
        return m_Controls.Gameplay.LeftClick.WasReleasedThisFrame();
    }
}
