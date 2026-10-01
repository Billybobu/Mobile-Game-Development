using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level2Spawner : MonoBehaviour
{
    public enemyWaveSpawner enemyWaveSpawner;
    int waveCount = 0;
    int prevWave = 0;
    bool phase2Started = false;
    bool bossSpawned = false;
    public boss2Spawner boss2Spawner;
    public bool bossDefeated = false;
    public float bossSpawnDelay;
    float nextLevelTimer = 5f;
    public scoreController scoreController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnWavesPhase1());
    }

    // Update is called once per frame
    void Update()
    {
        if (waveCount >= 20 && !phase2Started)
        {
            phase2Started = true;
            // Transition to phase 2
            Debug.Log("Transitioning to Phase 2");
            StartCoroutine(SpawnWavesPhase2());
        }
        if (waveCount >= 30 && !bossSpawned)
        {
            bossSpawnDelay -= Time.deltaTime;
            if (bossSpawnDelay <= 0)
            {
                bossSpawned = true;
                // Spawn Boss
                boss2Spawner.StartCoroutine(boss2Spawner.SpawnBoss());
            }
        }
        if (bossDefeated)
        {
            // Level complete
            nextLevelTimer -= Time.deltaTime;
            if (nextLevelTimer <= 0f)
            {
                GameObject.FindWithTag("Enemy")?.GetComponent<enemyDeathScript>()?.Die(); // Destroy all remaining enemies
                PlayerPrefs.SetInt("finalScore", scoreController.score);
                SceneManager.LoadScene("winScene");
            }
        }
    }

    IEnumerator SpawnWavesPhase1()
    {
        while (waveCount < 20)
        {
            int waveType = Random.Range(1, 12);
            if (waveType == prevWave)
            {
                yield return new WaitForSeconds(0f); // Skip this iteration to avoid repeating the same wave
            }
            else if (waveType == 1)
            {
                enemyWaveSpawner.BomberWaveLeft();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 2)
            {
                enemyWaveSpawner.BomberWaveRight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 3)
            {
                StartCoroutine(enemyWaveSpawner.DroneWaveLeft());
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 4)
            {
                enemyWaveSpawner.TwoFighterWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 5)
            {
                StartCoroutine(enemyWaveSpawner.DroneWaveRight());
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 6)
            {
                enemyWaveSpawner.FourSpeederWaveStraight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(3f);
            }
            else if (waveType == 7)
            {
                enemyWaveSpawner.ThreeSpeederWaveSin();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(3f);
            }
            else if (waveType == 8)
            {
                enemyWaveSpawner.SpawnSpaceStation();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 9)
            {
                enemyWaveSpawner.SpawnSniperLeft();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 10)
            {
                enemyWaveSpawner.SpawnSniperRight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 11)
            {
                enemyWaveSpawner.WaspWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
        }
    }

    IEnumerator SpawnWavesPhase2()
    {
        while (waveCount < 30)
        {
            int waveType = Random.Range(1, 11);
            if (waveType == prevWave)
            {
                yield return new WaitForSeconds(0f); // Skip this iteration to avoid repeating the same wave
            }
            else if (waveType == 1)
            {
                enemyWaveSpawner.BomberWaveLeft();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 2)
            {
                enemyWaveSpawner.BomberWaveRight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 3)
            {
                StartCoroutine(enemyWaveSpawner.DroneWaveLeft());
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 4)
            {
                enemyWaveSpawner.ThreeFighterWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 5)
            {
                StartCoroutine(enemyWaveSpawner.DroneWaveRight());
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 6)
            {
                enemyWaveSpawner.FiveSpeederWaveStraight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 7)
            {
                enemyWaveSpawner.FourSpeederWaveSin();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 8)
            {
                enemyWaveSpawner.SpawnSpaceStation();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 9)
            {
                enemyWaveSpawner.SpawnSniperBoth();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 10)
            {
                enemyWaveSpawner.WaspWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
