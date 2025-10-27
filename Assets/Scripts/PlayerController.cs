using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    public PlayerInputControls playerInput;
    private AnimationHandler AnimationHandler;

    protected override void Awake()
    {
        base.Awake();
        playerInput = new PlayerInputControls();
        AnimationHandler = GetComponent<AnimationHandler>();
        
    }
    
    private void OnEnable()
    {
        playerInput.Player.Enable();

        playerInput.Player.Move.performed += OnMovePerformed;
        playerInput.Player.Move.canceled += OnMoveCanceled;
        playerInput.Player.Move.started += AnimationHandler.AnimationStarted;
        playerInput.Player.Move.canceled += AnimationHandler.AnimationCanceled;

    }

    private void OnDisable()
    {
        playerInput.Player.Move.Disable();
    }

    void OnMovePerformed(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
        movementDirection = movementDirection.normalized;
        
    }
    void OnMoveCanceled(InputAction.CallbackContext context)
    {
        movementDirection = Vector2.zero; 
    }
}
