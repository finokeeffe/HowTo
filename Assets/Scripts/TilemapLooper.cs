using UnityEngine;

public class TilemapLooper : MonoBehaviour
{
    public Transform player;

    public float tileSize = 16f;

    public int width = 10;
    public int height = 10;

    private float worldWidth;
    private float worldHeight;

    void Start()
    {
        worldWidth = tileSize * width;
        worldHeight = tileSize * height;
    }

    void Update()
    {
        if (player == null) return;

        Vector3 pos = transform.position;

        float dx = player.position.x - pos.x;
        float dy = player.position.y - pos.y;

        if (Mathf.Abs(dx) > worldWidth / 2f)
        {
            pos.x += dx > 0 ? worldWidth : -worldWidth;
        }

        if (Mathf.Abs(dy) > worldHeight / 2f)
        {
            pos.y += dy > 0 ? worldHeight : -worldHeight;
        }

        transform.position = pos;
    }
}