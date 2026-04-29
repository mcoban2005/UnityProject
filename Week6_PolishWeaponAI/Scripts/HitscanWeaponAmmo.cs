using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Hitscan (raycast) silah örneği: ammo, cooldown ve reload içerir.
/// </summary>
public class HitscanWeaponAmmo : MonoBehaviour
{
    [Header("Input (New Input System)")]
    public InputActionReference fireAction;   // Player/Fire
    public InputActionReference reloadAction; // Player/Reload

    [Header("Raycast")]
    public Transform firePoint; // genelde kamera
    public float range = 60f;
    public float damage = 20f;
    public LayerMask hitMask = ~0;
    public bool debugDrawRay = false;

    [Header("Ammo")]
    public int magazineSize = 12;
    public int reserveAmmo = 60;
    public float fireCooldown = 0.1f; // rate of fire
    public float reloadTime = 1.2f;

    int currentAmmo;
    bool isReloading;
    float nextShotTime;
    float reloadEndsAt;

    public int CurrentAmmo => currentAmmo;
    public int ReserveAmmo => reserveAmmo;
    public bool IsReloading => isReloading;

    void Awake()
    {
        currentAmmo = magazineSize;
    }

    void OnEnable()
    {
        fireAction?.action.Enable();
        reloadAction?.action.Enable();
    }

    void OnDisable()
    {
        fireAction?.action.Disable();
        reloadAction?.action.Disable();
    }

    void Update()
    {
        if (isReloading && Time.time >= reloadEndsAt)
            FinishReload();

        // Ateş tutma: aksiyon Button olduğu için IsPressed ile sürekli atış sağlanır.
        if (fireAction != null && fireAction.action.IsPressed())
            TryShoot();

        if (!isReloading && reloadAction != null && reloadAction.action.WasPressedThisFrame())
            StartReload();
    }

    void TryShoot()
    {
        if (isReloading) return;
        if (Time.time < nextShotTime) return;
        if (firePoint == null) return;

        // Ammo bitti ise otomatik reload.
        if (currentAmmo <= 0)
        {
            if (reserveAmmo > 0)
                StartReload();
            return;
        }

        nextShotTime = Time.time + fireCooldown;
        currentAmmo--;

        Ray ray = new Ray(firePoint.position, firePoint.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, range, hitMask,
                QueryTriggerInteraction.Ignore))
        {
            if (debugDrawRay)
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.15f);

            Health health = hit.collider.GetComponentInParent<Health>();
            if (health != null)
                health.TakeDamage(damage);
        }
        else
        {
            if (debugDrawRay)
                Debug.DrawRay(ray.origin, ray.direction * range, Color.yellow, 0.15f);
        }
    }

    void StartReload()
    {
        if (isReloading) return;
        if (reserveAmmo <= 0) return;
        if (currentAmmo >= magazineSize) return;

        isReloading = true;
        reloadEndsAt = Time.time + reloadTime;
    }

    void FinishReload()
    {
        isReloading = false;

        int needed = magazineSize - currentAmmo;
        int toLoad = Mathf.Min(needed, reserveAmmo);

        currentAmmo += toLoad;
        reserveAmmo -= toLoad;
    }
}

