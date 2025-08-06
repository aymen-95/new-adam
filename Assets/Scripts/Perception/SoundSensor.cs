using UnityEngine;

public class SoundSensor : MonoBehaviour
{
    public float hearingRadius = 8f;

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, hearingRadius);
        foreach (var hit in hits)
        {
            SoundEmitter emitter = hit.GetComponent<SoundEmitter>();
            if (emitter != null)
            {
                Debug.Log("سمع صوت من: " + emitter.gameObject.name);
            }
        }
    }
}
