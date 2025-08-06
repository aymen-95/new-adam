using UnityEngine;

public class BasicTouchSensor : MonoBehaviour
{
    private AdamResponse response;

    void Start()
    {
        response = GetComponent<AdamResponse>();
        if (response == null)
        {
            response = gameObject.AddComponent<AdamResponse>();
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        string objectName = hit.gameObject.name;
        Debug.Log("آدم لمس: " + objectName);
        response.ReactTo("Touched " + objectName);
    }
}
