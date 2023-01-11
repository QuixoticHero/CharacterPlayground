using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRegister : MonoBehaviour
{
    [SerializeField] private TransformDatabase transformDatabase;

    private void OnEnable()
    {
        if (transformDatabase == null) return;

        transformDatabase.Add(transform);
    }

    private void OnDisable()
    {
        if (transformDatabase == null) return;

        transformDatabase.Remove(transform);
    }
}
