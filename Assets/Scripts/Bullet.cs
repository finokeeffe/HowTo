using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 12f;
    [SerializeField] private float lifetime = 3f;
    [SerializeField] private int damage = 1;

    private Rigidbody2D rb;

    private void Awake()
    {
        SetupComponents();
    }

    private void Start()
    {
        DestroyBulletAfterTime();
    }

    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void SetupComponents()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void MoveBullet()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void DestroyBulletAfterTime()
    {
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}