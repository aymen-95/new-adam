using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    void Start()
    {
        GameObject room = GameObject.CreatePrimitive(PrimitiveType.Cube);
        room.transform.localScale = new Vector3(10, 0.1f, 10);
        room.name = "Floor";

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.5f, 3);
        cube.name = "Test Cube";

        GameObject cameraObject = new GameObject("NewAdamEye");
        Camera cam = cameraObject.AddComponent<Camera>();
        cameraObject.AddComponent<NewAdamEye>();
        cameraObject.transform.position = new Vector3(0, 1, 0);
        cameraObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
