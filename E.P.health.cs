using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;

    public void IncreaseHealth(float amount)
    {
        health += amount;
    }
}


using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject healthPickupPrefab;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (healthPickupPrefab != null)
        {
            Instantiate(healthPickupPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
