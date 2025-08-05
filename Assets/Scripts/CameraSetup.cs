using UnityEngine;

public class CameraSetup : MonoBehaviour
{
    void Start()
    {
        GameObject cam = new GameObject("Main Camera");
        Camera cameraComponent = cam.AddComponent<Camera>();
        cam.AddComponent<AudioListener>();
        cam.AddComponent<SimpleCameraController>();

        cam.tag = "MainCamera";
        cam.transform.position = new Vector3(0f, 1.7f, -5f);
        cam.transform.LookAt(Vector3.zero);
    }
}
