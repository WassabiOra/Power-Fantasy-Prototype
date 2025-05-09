using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public int powerReward = 20;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.IncreasePower(powerReward);
        }

        Destroy(gameObject);
    }
}
