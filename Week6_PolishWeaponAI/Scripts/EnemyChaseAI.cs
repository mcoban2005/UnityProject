using UnityEngine;

/// <summary>
/// Basit enemy kovalamaca örneği:
/// - Oyuncu belli mesafede ise yaklaş
/// - Yakın menzildeyken cooldown ile hasar ver
/// </summary>
public class EnemyChaseAI : MonoBehaviour
{
    [Header("Target")]
    public string playerTag = "Player";

    [Header("Movement")]
    public float moveSpeed = 3f;
    public float aggroDistance = 25f;
    public float attackDistance = 1.8f;

    [Header("Attack")]
    public float damage = 15f;
    public float attackCooldown = 0.8f;

    [Header("Optional")]
    public bool rotateToFaceTarget = true;

    Transform playerTransform;
    Health playerHealth;
    Health enemyHealth;

    float nextAttackTime;

    void Awake()
    {
        enemyHealth = GetComponentInChildren<Health>();

        GameObject playerObj = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObj != null)
        {
            playerTransform = playerObj.transform;
            playerHealth = playerObj.GetComponentInChildren<Health>();
        }
    }

    void Update()
    {
        if (enemyHealth != null && enemyHealth.IsDead)
            return;

        if (playerTransform == null || playerHealth == null)
            return;

        Vector3 toTarget = playerTransform.position - transform.position;
        toTarget.y = 0f;

        float distance = toTarget.magnitude;
        if (distance > aggroDistance)
            return;

        if (distance > attackDistance)
        {
            Vector3 dir = distance > 0.001f ? toTarget / distance : Vector3.zero;
            transform.position += dir * moveSpeed * Time.deltaTime;

            if (rotateToFaceTarget && dir != Vector3.zero)
                transform.rotation = Quaternion.LookRotation(dir);
        }
        else
        {
            if (Time.time >= nextAttackTime)
            {
                nextAttackTime = Time.time + attackCooldown;
                playerHealth.TakeDamage(damage);
            }
        }
    }
}

