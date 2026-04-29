using UnityEngine;

/// <summary>
/// Health ölüm olayını dinleyip Playing / GameOver durumunu yönetir.
/// </summary>
public class GameStateController : MonoBehaviour
{
    public enum State { Playing, GameOver }

    public State state = State.Playing;

    [Header("Death Filtering")]
    public Health playerHealth; // GameOver sadece oyuncu ölünce tetiklensin

    public bool triggerOnPlayerOnly = true;

    [Header("UI/Behaviour")]
    public GameObject gameOverPanel;
    public bool freezeTimeOnGameOver = true;

    void OnEnable()
    {
        Health.OnAnyHealthDied += HandleHealthDied;
    }

    void OnDisable()
    {
        Health.OnAnyHealthDied -= HandleHealthDied;
    }

    void Start()
    {
        state = State.Playing;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    void HandleHealthDied(Health diedHealth)
    {
        if (state == State.GameOver) return;

        if (triggerOnPlayerOnly && playerHealth != null && diedHealth != playerHealth)
            return;

        GameOver();
    }

    public void GameOver()
    {
        state = State.GameOver;
        Debug.Log("GameOver!");

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        if (freezeTimeOnGameOver)
            Time.timeScale = 0f;
    }
}

