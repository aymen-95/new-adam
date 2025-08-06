using System.Collections.Generic;
using UnityEngine;

public class MemoryModule : MonoBehaviour
{
    private List<string> shortTermMemory = new List<string>();

    public void Remember(string fact)
    {
        if (!shortTermMemory.Contains(fact))
        {
            shortTermMemory.Add(fact);
            Debug.Log("تخزين في الذاكرة: " + fact);
        }
    }

    public bool Recall(string fact)
    {
        return shortTermMemory.Contains(fact);
    }

    public void PrintMemory()
    {
        Debug.Log("🧠 ذاكرة آدم:");
        foreach (var item in shortTermMemory)
        {
            Debug.Log("- " + item);
        }
    }
}
