using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetter : MonoBehaviour
{
    [SerializeField] private TransformVariable transformVariable;
    [SerializeField] private Transform presetTransform;

    public Transform GetTransform
    { 
        get 
        { 
            if(presetTransform == null)
            {
                presetTransform = transform;
            }
            return presetTransform; 
        } 
    }

    private void OnEnable()
    {
        if (transformVariable == null) return;

        transformVariable.Value = GetTransform;
    }

    private void OnDisable()
    {
        if (transformVariable == null || transformVariable.Value != GetTransform) return;

        transformVariable.Value = null;
    }
}
