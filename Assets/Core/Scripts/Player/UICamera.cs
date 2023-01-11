using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class UICamera : MonoBehaviour
{
    [SerializeField] private CharacterControllerVariable controllerVariable;
    [SerializeField] private CharacterCameraVariable cameraVariable;

    private PlayerUI playerUI;

    public bool IsCameraActive() { return cameraVariable || cameraVariable.Value != null; }

    public void SelectedCharacterController(KinematicCharacterController.Examples.CharacterController characterController)
    {
        if (!IsCameraActive()) return;

        cameraVariable.Value.SetFollowTransform(characterController.CameraFollowPoint);
    }

    private void Awake()
    {
        playerUI = new PlayerUI();
    }

    private void OnEnable()
    {
        playerUI.CameraController.Enable();
    }

    private void OnDisable()
    {
        playerUI.CameraController.Disable();
    }

    private void Update()
    {
        if (cameraVariable.Value == null || !playerUI.CameraController.enabled) return;

        CameraInputs();
    }

    private void CameraInputs()
    {
        Vector3 rotationInput = playerUI.CameraController.Rotation.ReadValue<Vector2>();
        float distance = playerUI.CameraController.Distance.ReadValue<float>();

        cameraVariable.Value.UpdateWithInput(Time.deltaTime, distance, rotationInput);
    }
}
