using UnityEngine;

/// <summary>
/// Enemy death'lerinden skor üretir.
/// (Health.OnAnyHealthDied event'i üzerinden; oyuncunun ölümü hariç tutulur.)
/// </summary>
public class ScoreManager : MonoBehaviour
{
    public int score;
    public int pointsPerKill = 10;

    [Header("Filter")]
    public Health playerHealth; // oyuncu ölünce skor artırma

    void OnEnable()
    {
        Health.OnAnyHealthDied += HandleAnyHealthDied;
    }

    void OnDisable()
    {
        Health.OnAnyHealthDied -= HandleAnyHealthDied;
    }

    void Start()
    {
        score = 0;
    }

    void HandleAnyHealthDied(Health diedHealth)
    {
        if (diedHealth == null) return;
        if (playerHealth != null && diedHealth == playerHealth) return;

        score += pointsPerKill;
        Debug.Log($"Skor: {score}");
    }
}

