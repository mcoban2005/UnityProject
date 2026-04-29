using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Hitscan ateşleme örneği: Mouse Left ile raycast atar, çarpanı Health üzerinden hasarlar.
/// </summary>
public class HitscanShooter : MonoBehaviour
{
    public InputActionReference fireAction; // Player/Fire
    public Transform firePoint; // genelde kamera center

    public float range = 50f;
    public float damage = 20f;
    public LayerMask hitMask = ~0;
    public bool debugDrawRay = false;

    void OnEnable()
    {
        fireAction?.action.Enable();
    }

    void OnDisable()
    {
        fireAction?.action.Disable();
    }

    void Update()
    {
        if (fireAction == null) return;

        if (fireAction.action.WasPressedThisFrame())
            Fire();
    }

    void Fire()
    {
        Transform origin = firePoint != null ? firePoint : transform;

        Vector3 start = origin.position;
        Vector3 dir = origin.forward;

        Ray ray = new Ray(start, dir);
        if (Physics.Raycast(ray, out RaycastHit hit, range, hitMask,
                QueryTriggerInteraction.Ignore))
        {
            if (debugDrawRay)
                Debug.DrawRay(start, dir * hit.distance, Color.red, 0.2f);

            Health health = hit.collider.GetComponentInParent<Health>();
            if (health != null)
                health.TakeDamage(damage);
        }
        else
        {
            if (debugDrawRay)
                Debug.DrawRay(start, dir * range, Color.yellow, 0.2f);
        }
    }
}

