using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class UISetCharacter : MonoBehaviour
{
    [SerializeField] private TransformVariable highlightVariable;
    [SerializeField] private TransformVariable selectedVariable;
    [SerializeField] private CharacterControllerVariable selectedCharacterVariable;

    private PlayerUI playerUI;

    public void SelectedCharacterController(KinematicCharacterController.Examples.CharacterController characterController)
    {
        if (characterController.transform == selectedVariable.Value) return;

        selectedVariable.Value = characterController.transform;
    }

    private void Awake()
    {
        playerUI = new PlayerUI();

        playerUI.CharacterController.SetCharacterController.performed
            += cxt => SetSelectedCharacter();
    }

    private void OnEnable()
    {
        playerUI.CharacterController.Enable();
    }

    private void OnDisable()
    {
        playerUI.CharacterController.Disable();
    }

    private void SetSelectedCharacter()
    {
        if (highlightVariable == null || selectedVariable == null || selectedCharacterVariable == null) return;

        if (highlightVariable.Value != null && selectedVariable.Value != highlightVariable.Value)
        {
            selectedVariable.Value = highlightVariable.Value;
            selectedCharacterVariable.Value 
                = selectedVariable.Value.GetComponent<KinematicCharacterController.Examples.CharacterController>();

            highlightVariable.Value = null;
        }
    }
}
