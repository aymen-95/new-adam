using UnityEngine;

public class EyeRayVisualizer : MonoBehaviour
{
    public float rayLength = 10f;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.green);

        if (Physics.Raycast(ray, out RaycastHit hit, rayLength))
        {
            Debug.Log("👁️ Eye sees: " + hit.collider.gameObject.name);
        }
    }
}
