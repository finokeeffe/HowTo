using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOverManager;

    private Health health;

    private void Awake()
    {
        health = GetComponent<Health>();
    }

    private void Start()
    {
        if (health != null)
        {
            health.OnDeath += HandleDeath;
        }
    }

    private void HandleDeath()
    {
        AudioManager.Instance.PlayGameOverSound();
        gameOverManager.ShowGameOver();
        gameObject.SetActive(false);
    }
}