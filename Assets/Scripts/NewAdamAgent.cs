using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NewAdamAgent : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform eye;

    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (eye == null)
        {
            Debug.LogWarning("Eye transform not assigned. Creating one...");
            GameObject eyeObject = new GameObject("Eye");
            eyeObject.transform.SetParent(transform);
            eyeObject.transform.localPosition = new Vector3(0, 1.6f, 0.5f);
            eye = eyeObject.transform;
        }

        // Attach visualizer
        eye.gameObject.AddComponent<Camera>();
        eye.gameObject.AddComponent<EyeRayVisualizer>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveDirection = new Vector3(h, 0, v);
        controller.SimpleMove(transform.TransformDirection(moveDirection) * moveSpeed);
    }
}
