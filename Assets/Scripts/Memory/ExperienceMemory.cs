using System.Collections.Generic;
using UnityEngine;

public class ExperienceMemory : MonoBehaviour
{
    private HashSet<string> painfulObjects = new HashSet<string>();

    /// <summary>
    /// تسجيل أن الجسم مؤلم
    /// </summary>
    public void RegisterPain(string objectName)
    {
        if (!painfulObjects.Contains(objectName))
        {
            painfulObjects.Add(objectName);
            Debug.Log($"🧠 Memory: Registered {objectName} as painful.");
        }
    }

    /// <summary>
    /// هل هذا الجسم مؤلم بحسب الذاكرة؟
    /// </summary>
    public bool IsPainful(string objectName)
    {
        return painfulObjects.Contains(objectName);
    }

    /// <summary>
    /// طباعة جميع الذكريات المؤلمة
    /// </summary>
    public void ListAllPainfulMemories()
    {
        Debug.Log("📚 Painful Memories:");
        foreach (var obj in painfulObjects)
        {
            Debug.Log(" - " + obj);
        }
    }
}
