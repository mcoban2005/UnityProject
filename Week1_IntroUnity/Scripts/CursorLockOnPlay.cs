using UnityEngine;

/// <summary>
/// Play sırasında imleci kilitler (FPS için).
/// </summary>
public class CursorLockOnPlay : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

