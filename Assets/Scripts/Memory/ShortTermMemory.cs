using System.Collections.Generic;
using UnityEngine;

public class ShortTermMemory : MonoBehaviour
{
    private Queue<string> memoryQueue = new Queue<string>();
    public int memoryLimit = 10;

    // يمكن إضافة ترويسة للحدث
    public delegate void OnNewMemoryAdded(string memory);
    public event OnNewMemoryAdded MemoryAddedEvent;

    /// <summary>
    /// يضيف معلومة جديدة إلى الذاكرة القصيرة ويزيل الأقدم إذا تم الوصول للحد.
    /// </summary>
    public void Remember(string info)
    {
        if (memoryQueue.Count >= memoryLimit)
        {
            string removed = memoryQueue.Dequeue(); // إزالة الأقدم
            Debug.Log("Memory removed: " + removed);
        }

        memoryQueue.Enqueue(info);
        Debug.Log("Memory added: " + info);

        // إطلاق حدث جديد
        MemoryAddedEvent?.Invoke(info);
    }

    /// <summary>
    /// إرجاع قائمة الذكريات الأخيرة.
    /// </summary>
    public string[] GetRecentMemories()
    {
        return memoryQueue.ToArray();
    }

    /// <summary>
    /// حذف كل الذكريات - مفيد لإعادة التشغيل أو بعد حدث صادم.
    /// </summary>
    public void ClearMemory()
    {
        memoryQueue.Clear();
        Debug.Log("Short-term memory cleared.");
    }
}
