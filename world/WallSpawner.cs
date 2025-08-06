using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    void Start()
    {
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.transform.localScale = new Vector3(3, 2, 0.2f);
        wall.transform.position = new Vector3(2, 1, 0);

        wall.AddComponent<BoxCollider>();
        wall.AddComponent<Rigidbody>().isKinematic = true;
        wall.AddComponent<HotWall>();
    }
}
