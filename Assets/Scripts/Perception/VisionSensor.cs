using UnityEngine;

public class VisionSensor : MonoBehaviour
{
    public float viewDistance = 10f;
    public float fieldOfView = 90f;

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, viewDistance);
        foreach (var hit in hits)
        {
            Vector3 direction = (hit.transform.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, direction) < fieldOfView / 2)
            {
                Debug.DrawLine(transform.position, hit.transform.position, Color.green);
                // مستقبلاً: تخزين هذا العنصر في ذاكرة آدم
                Debug.Log("رؤية العنصر: " + hit.gameObject.name);
            }
        }
    }
}
