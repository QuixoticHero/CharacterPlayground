using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using KinematicCharacterController.Examples;

public class UICharacter : MonoBehaviour
{
    [SerializeField] private CharacterControllerVariable controllerVariable;
    [SerializeField] private TransformVariable transformCameraVariable;

    private PlayerUI playerUI;

    private bool jump;
    private bool crouch;

    private void Awake()
    {
        playerUI = new PlayerUI();

        playerUI.CharacterController.Jump.performed
            += cxt => jump = cxt.ReadValueAsButton();
        playerUI.CharacterController.Crouch.performed
            += cxt => crouch = cxt.ReadValueAsButton();
    }

    private void OnEnable()
    {
        playerUI.CharacterController.Enable();
    }

    private void OnDisable()
    {
        playerUI.CharacterController.Disable();
    }

    // Update is called once per frame
    private void Update()
    {
        if (controllerVariable.Value == null || !playerUI.CharacterController.enabled) return;

        CharacterInputs();
    }

    private void CharacterInputs()
    {
        PlayerCharacterInputs playerCharacterInputs = new PlayerCharacterInputs();

        Vector2 moveInput = playerUI.CharacterController.Movement.ReadValue<Vector2>();
        playerCharacterInputs.MoveAxisForward = moveInput.y;
        playerCharacterInputs.MoveAxisRight = moveInput.x;

        playerCharacterInputs.JumpDown = jump;

        playerCharacterInputs.CrouchDown = crouch;
        playerCharacterInputs.CrouchUp = !crouch;

        if (transformCameraVariable.Value) { 
            playerCharacterInputs.CameraRotation = transformCameraVariable.Value.rotation;
        }

        controllerVariable.Value.SetInputs(ref playerCharacterInputs);
    }
}
