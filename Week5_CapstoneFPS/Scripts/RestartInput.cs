using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/// <summary>
/// Opsiyonel: R tuşu ile sahneyi yeniden başlat.
/// </summary>
public class RestartInput : MonoBehaviour
{
    public GameStateController gameStateController; // opsiyonel

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.rKey.wasPressedThisFrame)
            Restart();
    }

    public void Restart()
    {
        Time.timeScale = 1f;

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
}

