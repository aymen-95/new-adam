using System.Collections.Generic;
using UnityEngine;

public class ShortTermMemory : MonoBehaviour
{
    private Queue<string> memoryQueue = new Queue<string>();
    public int memoryLimit = 10;

    public void Remember(string info)
    {
        if (memoryQueue.Count >= memoryLimit)
        {
            memoryQueue.Dequeue(); // Remove oldest
        }

        memoryQueue.Enqueue(info);
        Debug.Log("Memory added: " + info);
    }

    public string[] GetRecentMemories()
    {
        return memoryQueue.ToArray();
    }
}
