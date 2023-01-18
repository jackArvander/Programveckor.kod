using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // The speed at which the platform moves
    public float speed = 2f;

    // The distance that the platform moves
    public float distance = 15f;

    // The direction that the platform is moving
    // 1 = up, -1 = down
    private int direction = 1;

    // The starting position of the platform
    private Vector2 startPosition;

    void Start()
    {
        // Save the starting position of the platform
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position of the platform
        float newPosition = Mathf.Sin(Time.time * speed);
        transform.position = startPosition + new Vector2(0, newPosition * distance * direction);
    }
}
