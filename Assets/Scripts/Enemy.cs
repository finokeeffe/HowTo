using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int scoreValue = 100;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float lifeTime = 15f;
    protected Health health;
    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        SetupComponents();
    }

    protected virtual void Start()
    {
        if (health != null)
        {
            health.OnDeath += Die;
        }
        Destroy(gameObject, lifeTime);
    }

    protected virtual void FixedUpdate()
    {
        Move();
    }

    protected virtual void SetupComponents()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Health>();
    }

    protected abstract void Move();


    protected float GetMoveSpeed()
    {
        return moveSpeed;
    }
    protected virtual void Die()
    {
        // OnEnemyDestroyed?.Invoke();
        ScoreManager.Instance.AddScore(scoreValue);
        AudioManager.Instance.PlayEnemyDeathSound();
        Destroy(gameObject);
    }
}