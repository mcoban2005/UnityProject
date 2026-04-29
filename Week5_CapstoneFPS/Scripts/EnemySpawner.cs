using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Belirli aralıklarla enemy prefab spawn eder.
/// Enemy'lerin ölümü Health.OnAnyHealthDied event'i ile takip edilir.
/// </summary>
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;

    public float spawnInterval = 2f;
    public int maxEnemies = 20;

    [Header("Optional")]
    public Health playerHealth; // sadece oyuncu ölse de spawner'ı etkilememek için

    float timer;

    readonly HashSet<Health> trackedEnemies = new HashSet<Health>();

    void OnEnable()
    {
        Health.OnAnyHealthDied += HandleAnyHealthDied;
    }

    void OnDisable()
    {
        Health.OnAnyHealthDied -= HandleAnyHealthDied;
    }

    void Update()
    {
        if (enemyPrefab == null || spawnPoints == null || spawnPoints.Length == 0)
            return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval && trackedEnemies.Count < maxEnemies)
        {
            timer = 0f;
            SpawnOne();
        }
    }

    void SpawnOne()
    {
        Transform p = spawnPoints[Random.Range(0, spawnPoints.Length)];
        if (p == null) return;

        GameObject obj = Instantiate(enemyPrefab, p.position, p.rotation);

        // Enemy prefab içinde/çocuklarında Health olmalı.
        Health h = obj.GetComponentInChildren<Health>();
        if (h == null)
        {
            Debug.LogWarning("Enemy prefab içinde Health bulunamadı. Spawner takip edemez.");
            return;
        }

        trackedEnemies.Add(h);
    }

    void HandleAnyHealthDied(Health diedHealth)
    {
        if (diedHealth == null) return;
        if (playerHealth != null && diedHealth == playerHealth) return;

        if (trackedEnemies.Remove(diedHealth))
        {
            // trackedEnemies.Count otomatik güncellenecek.
        }
    }
}

