using UnityEngine;

public class AsteroidEnemy : Enemy
{
    [SerializeField] private float horizontalMovementRange = 2f;
    [SerializeField] private float rotationSpeed = 200f;

    private float horizontalDirection;

    protected override void Start()
    {
        base.Start();

        ChooseRandomDirection();
    }

    protected override void Move()
    {
        Vector2 movement = new Vector2(
            horizontalDirection,
            -1f
        ).normalized;

        rb.linearVelocity = movement * GetMoveSpeed();

        RotateAsteroid();
    }

    private void ChooseRandomDirection()
    {
        horizontalDirection = Random.Range(
            -horizontalMovementRange,
             horizontalMovementRange
        );
    }

    private void RotateAsteroid()
    {
        transform.Rotate(
            0f,
            0f,
            rotationSpeed * Time.deltaTime
        );
    }
}