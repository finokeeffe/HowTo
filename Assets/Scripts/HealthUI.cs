using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image healthImage;

    [SerializeField] private Sprite health5;
    [SerializeField] private Sprite health4;
    [SerializeField] private Sprite health3;
    [SerializeField] private Sprite health2;
    [SerializeField] private Sprite health1;
    [SerializeField] private Sprite health0;

    private void Update()
    {
        UpdateHealthDisplay();
    }

    private void UpdateHealthDisplay()
    {
        switch (playerHealth.GetCurrentHealth())
        {
            case 5:
                healthImage.sprite = health5;
                break;

            case 4:
                healthImage.sprite = health4;
                break;

            case 3:
                healthImage.sprite = health3;
                break;

            case 2:
                healthImage.sprite = health2;
                break;

            case 1:
                healthImage.sprite = health1;
                break;

            default:
                healthImage.sprite = health0;
                break;
        }
    }
}