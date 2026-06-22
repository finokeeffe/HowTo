using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Transform player;
    public float parallaxAmount = 0.2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 movement = player.position * parallaxAmount;

        transform.position = new Vector3(
            startPosition.x + movement.x,
            startPosition.y + movement.y,
            transform.position.z
        );
    }
}