using UnityEngine;

public class DroneEnemy : Enemy
{
    protected override void Move()
    {
        rb.linearVelocity = Vector2.down * GetMoveSpeed();
    }
}