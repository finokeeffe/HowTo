using UnityEngine;

public class ChaserEnemy : Enemy
{
    private Transform player;

    protected override void Move()
    {
        if (player == null) return;

        Vector2 direction =
            (player.position - transform.position).normalized;

        rb.linearVelocity =
            direction * GetMoveSpeed();
    }

    protected override void Start()
    {
        base.Start();

        FindPlayer();
    }

    private void FindPlayer()
    {
        GameObject playerObject =
            GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }
}