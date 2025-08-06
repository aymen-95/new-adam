using UnityEngine;

public class BasicTouchSensor : MonoBehaviour
{
    private ExperienceMemory memory;

    void Start()
    {
        memory = GetComponent<ExperienceMemory>();
        if (memory == null)
        {
            memory = gameObject.AddComponent<ExperienceMemory>();
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("HotWall"))
        {
            Debug.Log("🔥 NewAdam touched a hot wall! Pain perceived.");
            memory.RegisterPain(hit.gameObject.name);
        }
        else
        {
            Debug.Log("🟢 Touched: " + hit.gameObject.name);
        }

        if (memory.IsPainful(hit.gameObject.name))
        {
            Debug.Log("⚠️ Avoid this! " + hit.gameObject.name + " is remembered as painful.");
            // لاحقًا: رد فعل (ابتعاد، قلق، صوت...)
        }
    }
}
