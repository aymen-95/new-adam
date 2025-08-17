using UnityEngine;

public class HotWall : MonoBehaviour
{
    void Start()
    {
        gameObject.name = "HotWall";
    }

   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "NewAdam")
        {
            var response = collision.gameObject.GetComponent<AdamResponse>();
            var memory = collision.gameObject.GetComponent<ShortTermMemory>();
    
            if (response != null)
            {
                response.ReactTo("Burned by HotWall");
            }
    
            if (memory != null)
            {
                memory.RecordEvent("Touched HotWall", Time.time.ToString("F2"));
            }
        }
    }
}
