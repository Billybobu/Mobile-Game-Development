using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level1Spawner : MonoBehaviour
{
    public enemyWaveSpawner enemyWaveSpawner;
    int waveCount = 0;
    int prevWave = 0;
    bool phase2Started = false;
    bool bossSpawned = false;
    public GameObject boss1;
    bool bossDefeated = false;
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
                Instantiate(boss1, new Vector3(0, 6, 0), Quaternion.Euler(0, 0, 180));
                StartCoroutine(SpawnWavesBoss());
            }
        }
        if (bossSpawned && GameObject.FindWithTag("Boss") == null)
        {
            bossDefeated = true;
            GameObject.FindWithTag("Enemy")?.GetComponent<enemyDeathScript>()?.Die(); // Destroy all remaining enemies
        }
        if (bossDefeated)
        {
            // Level complete
            Debug.Log("Level Complete!");
            nextLevelTimer -= Time.deltaTime;
            if (nextLevelTimer <= 0f)
            {
                PlayerPrefs.SetInt("finalScore", scoreController.score);
                SceneManager.LoadScene("nextLevelScene");
            }
        }
    }

    IEnumerator SpawnWavesPhase1()
    {
        while (waveCount < 20)
        {
            int waveType = Random.Range(1, 8);
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
                enemyWaveSpawner.FighterWave();
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
                enemyWaveSpawner.ThreeSpeederWaveStraight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(3f);
            }
            else if (waveType == 7)
            {
                enemyWaveSpawner.TwoSpeederWaveSin();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(3f);
            }
        }
    }

    IEnumerator SpawnWavesPhase2()
    {
        while (waveCount < 30)
        {
            int waveType = Random.Range(1, 6);
            if (waveType == prevWave)
            {
                yield return new WaitForSeconds(0f); // Skip this iteration to avoid repeating the same wave
            }
            else if (waveType == 1)
            {
                enemyWaveSpawner.BomberWaveBoth();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 2)
            {
                enemyWaveSpawner.ThreeSpeederWaveSin();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 3)
            {
                StartCoroutine(enemyWaveSpawner.DroneWaveBoth());
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(10f);
            }
            else if (waveType == 4)
            {
                enemyWaveSpawner.TwoFighterWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 5)
            {
                enemyWaveSpawner.FourSpeederWaveStraight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
        }
    }

    IEnumerator SpawnWavesBoss()
    {
        while (!bossDefeated)
        {
            int waveType = Random.Range(1, 8);
            if (waveType == prevWave)
            {
                yield return new WaitForSeconds(0f); // Skip this iteration to avoid repeating the same wave
            }
            else if (waveType == 1)
            {
                enemyWaveSpawner.SingleDroneRight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 2)
            {
                enemyWaveSpawner.FighterWave();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 3)
            {
                enemyWaveSpawner.SingleDroneLeft();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(8f);
            }
            else if (waveType == 4)
            {
                enemyWaveSpawner.ThreeSpeederWaveStraight();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
            else if (waveType == 5)
            {
                enemyWaveSpawner.TwoSpeederWaveSin();
                waveCount++;
                prevWave = waveType;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
