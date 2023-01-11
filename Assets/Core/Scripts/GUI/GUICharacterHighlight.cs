using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUICharacterHighlight : MonoBehaviour
{
    [SerializeField] private TransformVariable cameraTransformVariable;

    [SerializeField] private TransformDatabase transformDatabase;
    [SerializeField] private TransformVariable highlightVariable;
    [SerializeField] private TransformVariable selectedVariable;

    [SerializeField] private Vector2Variable uiScreenSpacePosition;
    [SerializeField] private Vector3Variable uiWorldSpacePosition;

    [SerializeField] private float CanvasHeight = 1200;
    [SerializeField] private float CanvasWidth = 1600;

    [SerializeField] protected float fps = 0.04167f;
    [SerializeField] protected int currFps;

    int m_frameCounter = 0;
    float m_timeCounter = 0.0f;

    private void Awake()
    {
    }

    public IEnumerator Start()
    {
        while (true)
        {
            FrameCounter();
            UpdateFrame();
            yield return new WaitForSeconds(fps);
        }
    }

    private void FrameCounter()
    {
        if (Time.time > m_timeCounter)
        {
            m_timeCounter = Time.time + 1;

            currFps = m_frameCounter;
            m_frameCounter = 0;
        }
        else
        {
            m_frameCounter++;
        }
    }

    private void UpdateFrame()
    {
        if (!transformDatabase) return;

        highlightVariable.Value = transformDatabase
            .GetValueWithinRange(cameraTransformVariable.Value.position, cameraTransformVariable.Value.forward, selectedVariable.Value);

        UpdateScreenSpaceGUI();
        UpdateWorldSpaceGUI();
    }

    public void UpdateScreenSpaceGUI()
    {
        if (uiScreenSpacePosition == null) return;

        if (highlightVariable.Value == null)
        {
            uiScreenSpacePosition.Value = Vector2.zero;
            return;
        }

        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(highlightVariable.Value.position);
        uiScreenSpacePosition.Value = new Vector2(viewportPosition.x * CanvasWidth, viewportPosition.y * CanvasHeight);
    }

    public void UpdateWorldSpaceGUI()
    {
        if (uiWorldSpacePosition == null) return;

        if (highlightVariable.Value == null)
        {
            uiWorldSpacePosition.Value = Vector3.zero;
            return;
        }

        uiWorldSpacePosition.Value = highlightVariable.Value.position;
    }

}
