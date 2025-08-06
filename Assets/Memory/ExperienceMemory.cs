using System.Collections.Generic;
using UnityEngine;

public class ExperienceMemory : MonoBehaviour
{
    private HashSet<string> painfulObjects = new HashSet<string>();

    public void RegisterPain(string objectName)
    {
        if (!painfulObjects.Contains(objectName))
        {
            painfulObjects.Add(objectName);
            Debug.Log("🧠 Learned that " + objectName + " causes pain.");
        }
    }

    public bool IsPainful(string objectName)
    {
        return painfulObjects.Contains(objectName);
    }
}
