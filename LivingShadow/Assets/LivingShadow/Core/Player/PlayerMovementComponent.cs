using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private InputActionAsset _inputActionAsset;

    [Header("Properties")]
    [SerializeField] private float _speed = 10.0f;

    private InputAction _moveAction;

    private Vector2 _movementDirection;

    private void Awake()
    {
        _moveAction = _inputActionAsset.FindAction("Move");
    }

    private void Update()
    {
        transform.position += new Vector3(_movementDirection.x, _movementDirection.y, 0) * _speed * Time.deltaTime;
    }

    private void OnEnable()
    {
        _moveAction.performed += OnMove;
        _moveAction.canceled += OnMoveStop;
    }

    private void OnDisable()
    {
        _moveAction.performed -= OnMove;
        _moveAction.canceled -= OnMoveStop;
    }


    private void OnMoveStop(InputAction.CallbackContext context)
    {
        _movementDirection = Vector3.zero;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _movementDirection = context.ReadValue<Vector2>();
    }
}
