using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerSetter : MonoBehaviour
{
    [SerializeField] private CharacterControllerVariable controllerVariable;
    
    private KinematicCharacterController.Examples.CharacterController _characterController;

    public KinematicCharacterController.Examples.CharacterController Controller 
    { 
        get 
        { 
            if(_characterController == null)
            {
                _characterController 
                    = GetComponent<KinematicCharacterController.Examples.CharacterController>();
            }
            return _characterController; 
        } 
    }

    private void OnEnable()
    {
        if (controllerVariable == null) return;

        controllerVariable.Value = Controller;
    }

    private void OnDisable()
    {
        if (controllerVariable == null || controllerVariable.Value != Controller) return;

        controllerVariable.Value = null;
    }
}
