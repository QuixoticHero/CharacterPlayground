using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "TransformDatabase", menuName = "Database/TransformDatabase", order = 120)]
public class TransformDatabase : ScriptableObject
{
    private List<Transform> targets = new List<Transform>();

    [Range(0, 2)]
    [SerializeField] private float distanceImportanceMod = 0.2f;

    [Range(0.707f, 1)]
    [SerializeField] private float povAngle = 0.9f;

    [Range(5, 30)]
    [SerializeField] private float maxDistance = 15;

    [Serializable]
    private struct TransformData
    {
        public Transform target;
        public float angle;
        public float dist;

        public TransformData(Transform t, float a, float d)
        {
            target = t;
            angle = a;
            dist = d;
        }

        public float GetClosest()
        {
            return angle - dist;
        }
    }

    public Transform[] GetValuessWithinRange(Vector3 origin, Vector3 forward)
    {
        List<Transform> inRange = new List<Transform>();

        foreach (Transform target in targets)
        {
            float targetDot = Vector3.Dot(forward, (target.position - origin).normalized);
            float distance = Vector3.Distance(target.position, origin) / maxDistance;

            if (targetDot > povAngle && distance < 1)
            {
                inRange.Add(target);
            }
        }

        return inRange.ToArray();
    }

    public Transform GetValueWithinRange(Vector3 origin, Vector3 forward, Transform ignoreTarget = null)
    {
        //List<TransformData> inRange = new List<TransformData>();
        TransformData result = new TransformData();

        foreach (Transform target in targets)
        {
            if (ignoreTarget == target) continue;

            float targetDot = Vector3.Dot(forward, (target.position - origin).normalized);
            float distance = Vector3.Distance(target.position, origin) / maxDistance;

            if (targetDot > povAngle && distance < 1)
            {
                if(result.target == null || targetDot - (distance * distanceImportanceMod) > result.GetClosest())
                {
                    result = new TransformData(target, targetDot, distance * distanceImportanceMod);
                }
            }
        }

        return result.target;//(inRange.Count > 0) ? inRange[0].target : null;
    }

    public Transform[] GetArray()
    {
        return targets.ToArray();
    }

    public void Add(Transform target)
    {
        targets.Add(target);
    }

    public void Remove(Transform target)
    {
        if (targets.Contains(target))
        {
            targets.Remove(target);
        }
    }
}
