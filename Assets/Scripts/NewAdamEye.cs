using UnityEngine;

public class NewAdamEye : MonoBehaviour
{
    public float viewDistance = 10f;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, viewDistance))
        {
            Debug.Log("New Adam sees: " + hit.collider.name);
        }
    }
}
