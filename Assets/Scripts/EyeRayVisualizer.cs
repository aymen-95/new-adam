using UnityEngine;

[RequireComponent(typeof(Camera))]
public class EyeRayVisualizer : MonoBehaviour
{
    public float rayLength = 10f;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        Gizmos.DrawRay(origin, direction * rayLength);
    }
}
