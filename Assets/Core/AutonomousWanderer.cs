using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class AutonomousWanderer : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float changeDirectionInterval = 2f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private float timer;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        PickNewDirection();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            PickNewDirection();
        }

        controller.SimpleMove(moveDirection * moveSpeed);
    }

    void PickNewDirection()
    {
        float angle = Random.Range(0f, 360f);
        moveDirection = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle));
        timer = changeDirectionInterval;
    }
}
