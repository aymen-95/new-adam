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
            if (response != null)
            {
                response.ReactTo("Burned by HotWall");
            }
        }
    }
}
