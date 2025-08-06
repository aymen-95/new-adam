using UnityEngine;

public class SoundEmitter : MonoBehaviour
{
    public void EmitSound()
    {
        Debug.Log("صوت انبعث من: " + gameObject.name);
    }
}
