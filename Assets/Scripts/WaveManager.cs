using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner enemySpawner;

    [SerializeField] private float timeBetweenWaves = 3f;
    [SerializeField] private float spawnDelay = 0.8f;

    private int currentWave = 1;
    private bool isSpawning;

    private void Start()
    {
        StartNextWave();
    }

    private void StartNextWave()
    {
        if (!isSpawning)
        {
            StartCoroutine(SpawnWave());
        }
    }

    private System.Collections.IEnumerator SpawnWave()
    {
        isSpawning = true;

        int enemiesToSpawn = CalculateEnemiesForWave();

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            enemySpawner.SpawnEnemy();

            yield return new WaitForSeconds(spawnDelay);
        }

        isSpawning = false;

        currentWave++;

        yield return new WaitForSeconds(timeBetweenWaves);

        StartNextWave();
    }

    private int CalculateEnemiesForWave()
    {
        return currentWave + 2;
    }
}