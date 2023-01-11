using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    private PlayerUI playerUI;

    private void Awake()
    {
        playerUI = new PlayerUI();

        playerUI.LockCursor.Lock.performed
            += cxt =>
            {
                if (Cursor.lockState != CursorLockMode.Locked)
                    Cursor.lockState = CursorLockMode.Locked;
            };

        playerUI.LockCursor.Enable();
    }

    private void OnEnable()
    {
        playerUI.LockCursor.Enable();
    }

    private void OnDisable()
    {
        playerUI.LockCursor.Disable();
    }
}
