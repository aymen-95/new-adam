using UnityEngine;

public class MainSceneInitializer : MonoBehaviour
{
    void Start()
    {
        CreateRoom();
        SpawnNewAdam();

        // أضف هذا السطر فقط
        gameObject.AddComponent<CameraSetup>();
    }

    void CreateRoom()
    {
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.localScale = new Vector3(10, 0.1f, 10);
        floor.transform.position = new Vector3(0, -0.05f, 0);
        floor.name = "Floor";
    }

    void SpawnNewAdam()
    {
        GameObject adam = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        adam.transform.position = new Vector3(0, 1, 0);
        adam.name = "NewAdam";
        adam.AddComponent<CharacterController>();
        adam.AddComponent<NewAdamAgent>();
    }
}
