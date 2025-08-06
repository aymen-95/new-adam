using UnityEngine;

public class AdamResponse : MonoBehaviour
{
    private MemoryModule memory;

    void Start()
    {
        memory = GetComponent<MemoryModule>();
        if (memory == null)
            memory = gameObject.AddComponent<MemoryModule>();
    }

    public void ReactTo(string stimulus)
    {
        if (!memory.Recall(stimulus))
        {
            memory.Remember(stimulus);
            Debug.Log("آدم يتفاعل لأول مرة مع: " + stimulus);
        }
        else
        {
            Debug.Log("آدم يتذكر هذا من قبل ويتفاعل بشكل مختلف مع: " + stimulus);
        }
    }
}
