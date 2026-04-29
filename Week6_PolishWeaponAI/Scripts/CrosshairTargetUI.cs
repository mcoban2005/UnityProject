using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Crosshair'ı raycast hedefe göre renklendirir.
/// </summary>
public class CrosshairTargetUI : MonoBehaviour
{
    public Camera playerCamera;
    public Image crosshairImage;

    public Color defaultColor = Color.white;
    public Color targetColor = Color.red;

    public float maxDistance = 100f;
    public LayerMask hitMask = ~0;

    void Reset()
    {
        crosshairImage = GetComponent<Image>();
        playerCamera = Camera.main;
    }

    void Update()
    {
        if (crosshairImage == null) return;

        if (playerCamera == null)
            playerCamera = Camera.main;
        if (playerCamera == null) return;

        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        bool isTarget = false;

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, hitMask,
                QueryTriggerInteraction.Ignore))
        {
            isTarget = hit.collider.GetComponentInParent<Health>() != null;
        }

        crosshairImage.color = isTarget ? targetColor : defaultColor;
    }
}

