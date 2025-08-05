using UnityEngine;

public class BasicRoom : MonoBehaviour
{
    public Vector3 roomSize = new Vector3(10f, 3f, 10f);
    public Material wallMaterial;
    public Material floorMaterial;

    void Start()
    {
        CreateFloor();
        CreateWalls();
    }

    void CreateFloor()
    {
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.position = new Vector3(0, -0.5f, 0);
        floor.transform.localScale = new Vector3(roomSize.x, 1f, roomSize.z);
        floor.name = "Floor";

        if (floorMaterial != null)
            floor.GetComponent<Renderer>().material = floorMaterial;
    }

    void CreateWalls()
    {
        float wallThickness = 0.2f;
        float height = roomSize.y;

        Vector3[] positions = new Vector3[]
        {
            new Vector3(0, height/2f, -roomSize.z/2f), // back
            new Vector3(0, height/2f, roomSize.z/2f),  // front
            new Vector3(-roomSize.x/2f, height/2f, 0), // left
            new Vector3(roomSize.x/2f, height/2f, 0)   // right
        };

        Vector3[] scales = new Vector3[]
        {
            new Vector3(roomSize.x, height, wallThickness),
            new Vector3(roomSize.x, height, wallThickness),
            new Vector3(wallThickness, height, roomSize.z),
            new Vector3(wallThickness, height, roomSize.z)
        };

        for (int i = 0; i < 4; i++)
        {
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.transform.position = positions[i];
            wall.transform.localScale = scales[i];
            wall.name = "Wall_" + i;

            if (wallMaterial != null)
                wall.GetComponent<Renderer>().material = wallMaterial;
        }
    }
}
