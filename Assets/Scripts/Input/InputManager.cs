using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    [SerializeField] private Mediator _mediator;

    private PlayerInput _input;


    private void Awake()
    {
        _input = new PlayerInput();
    }

    public void OnUpDownMovement(InputAction.CallbackContext context)
    {
        _mediator.MoveUpDown(Mathf.RoundToInt(_input.MoveGrid.Up_Down.ReadValue<float>()));
    }

    public void OnLeftRightMovement(InputAction.CallbackContext context)
    {
        _mediator.MoveLeftRight(Mathf.RoundToInt(_input.MoveGrid.Left_Right.ReadValue<float>()));
    }

    private void OnEnable()
    {
        _input.Enable();
        _input.MoveGrid.Up_Down.performed += OnUpDownMovement;
        _input.MoveGrid.Left_Right.performed += OnLeftRightMovement;
    }

    private void OnDisable()
    {
        _input.Disable();
        _input.MoveGrid.Up_Down.performed -= OnUpDownMovement;
        _input.MoveGrid.Left_Right.performed -= OnLeftRightMovement;
    }
}
