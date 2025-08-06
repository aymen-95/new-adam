// File: Scripts/Perception/EyePerception.cs
using UnityEngine;

public class EyePerception : MonoBehaviour
{
    public float viewRange = 10f;
    public float viewAngle = 90f;
    public LayerMask perceptionMask;

    public string[] visibleObjects;

    void Update()
    {
        ScanEnvironment();
    }

    void ScanEnvironment()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, viewRange, perceptionMask);
        visibleObjects = new string[hits.Length];

        for (int i = 0; i < hits.Length; i++)
        {
            Vector3 directionToTarget = hits[i].transform.position - transform.position;
            float angle = Vector3.Angle(transform.forward, directionToTarget);

            if (angle < viewAngle / 2f)
            {
                visibleObjects[i] = hits[i].gameObject.name;
            }
        }
    }
}
