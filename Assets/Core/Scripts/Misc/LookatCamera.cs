using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatCamera : MonoBehaviour
{
    [SerializeField] private TransformVariable cameraTransformVariable;

    // Update is called once per frame
    void Update()
    {
        if(cameraTransformVariable == null || cameraTransformVariable.Value == null) return;

        transform.LookAt(cameraTransformVariable.Value);
    }
}
