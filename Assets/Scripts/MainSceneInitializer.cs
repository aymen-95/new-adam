using UnityEngine;

public class MainSceneInitializer : MonoBehaviour
{
    void Start()
    {
        // إنشاء الغرفة
        GameObject room = new GameObject("BasicRoom");
        room.AddComponent<BasicRoom>();

        // إنشاء آدم الجديد
        GameObject adam = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        adam.transform.position = new Vector3(0, 1, 0);
        adam.name = "NewAdam";
        adam.AddComponent<CharacterController>();
        adam.AddComponent<NewAdamAgent>();
    }
}
