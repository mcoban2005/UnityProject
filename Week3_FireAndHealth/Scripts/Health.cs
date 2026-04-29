using UnityEngine;

/// <summary>
/// Basit health bileşeni.
/// (Week 4/5’te UI ve GameOver mantığı için kullanılacak şekilde) ölüm olayı yayınlar.
/// </summary>
public class Health : MonoBehaviour
{
    public static event System.Action<Health> OnAnyHealthDied;

    public float maxHealth = 100f;
    public float currentHealth;
    public bool destroyOnDeath = false;

    public bool IsDead => currentHealth <= 0f;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if (IsDead) return;

        currentHealth -= amount;
        currentHealth = Mathf.Max(0f, currentHealth);

        Debug.Log($"{name} aldı: {amount} | kalan: {currentHealth}");

        if (currentHealth <= 0f)
            Die();
    }

    void Die()
    {
        Debug.Log($"{name} öldü.");
        OnAnyHealthDied?.Invoke(this);

        if (destroyOnDeath)
            Destroy(gameObject);
        else
            gameObject.SetActive(false);
    }
}

