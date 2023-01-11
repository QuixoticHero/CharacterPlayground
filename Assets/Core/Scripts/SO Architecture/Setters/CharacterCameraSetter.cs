using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCameraSetter : MonoBehaviour
{
    [SerializeField] private CharacterCameraVariable cameraVariable;

    private KinematicCharacterController.Examples.CharacterCamera _characterCamera;

    public KinematicCharacterController.Examples.CharacterCamera CharacterCamera
    {
        get
        {
            if (_characterCamera == null)
            {
                _characterCamera
                    = GetComponent<KinematicCharacterController.Examples.CharacterCamera>();
            }
            return _characterCamera;
        }
    }

    private void OnEnable()
    {
        if (cameraVariable == null) return;

        cameraVariable.Value = CharacterCamera;
    }

    private void OnDisable()
    {
        if (cameraVariable == null || cameraVariable.Value != CharacterCamera) return;

        cameraVariable.Value = null;
    }
}
