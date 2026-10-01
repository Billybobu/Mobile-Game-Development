using UnityEngine;
using System.Collections;

public class enemyWaveSpawner : MonoBehaviour
{
    // Enemy Prefabs
    public GameObject droneLeft;
    public GameObject droneRight;
    public GameObject fighter;
    public GameObject speederStraight;
    public GameObject speederSin;
    public GameObject bomberLeft;
    public GameObject bomberRight;
    public GameObject spaceStation;
    public GameObject sniperRight;
    public GameObject sniperLeft;
    public GameObject wasp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BomberWaveLeft()
    {
        Instantiate(bomberLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void BomberWaveRight() 
    {
        Instantiate(bomberRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void BomberWaveBoth()
    {
        Instantiate(bomberLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(bomberRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void FighterWave()
    {
        float spawnPoint = Random.Range(-5, 6);
        Instantiate(fighter, new Vector3(spawnPoint, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void TwoFighterWave()
    {
        float spawnPoint1 = Random.Range(-5, 0);
        float spawnPoint2 = Random.Range(0, 6);
        Instantiate(fighter, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(fighter, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void ThreeFighterWave() 
    {
        float spawnPoint1 = Random.Range(-5, -1);
        float spawnPoint2 = Random.Range(-1, 2);
        float spawnPoint3 = Random.Range(2, 6);
        Instantiate(fighter, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(fighter, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(fighter, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
    }

     public void ThreeSpeederWaveStraight()
    {
        float spawnPoint1 = Random.Range(-8, -3);
        float spawnPoint2 = Random.Range(-2, 3);
        float spawnPoint3 = Random.Range(4, 9);
        Instantiate(speederStraight, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void FourSpeederWaveStraight()
    {
        float spawnPoint1 = Random.Range(-8, -4);
        float spawnPoint2 = Random.Range(-3, 0);
        float spawnPoint3 = Random.Range(1, 4);
        float spawnPoint4 = Random.Range(5, 9);
        Instantiate(speederStraight, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint4, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void FiveSpeederWaveStraight()
    {
        float spawnPoint1 = Random.Range(-8, -5);
        float spawnPoint2 = Random.Range(-4, -1);
        float spawnPoint3 = Random.Range(0, 2);
        float spawnPoint4 = Random.Range(3, 6);
        float spawnPoint5 = Random.Range(7, 9);
        Instantiate(speederStraight, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint4, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederStraight, new Vector3(spawnPoint5, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void TwoSpeederWaveSin()
    {
        float spawnPoint1 = Random.Range(-7, 0);
        float spawnPoint2 = Random.Range(0, 8);
        Instantiate(speederSin, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void ThreeSpeederWaveSin() 
    {
        float spawnPoint1 = Random.Range(-7, -2);
        float spawnPoint2 = Random.Range(-1, 3);
        float spawnPoint3 = Random.Range(4, 8);
        Instantiate(speederSin, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void FourSpeederWaveSin()
    {
        float spawnPoint1 = Random.Range(-7, -3);
        float spawnPoint2 = Random.Range(-2, 0);
        float spawnPoint3 = Random.Range(1, 4);
        float spawnPoint4 = Random.Range(5, 8);
        Instantiate(speederSin, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(speederSin, new Vector3(spawnPoint4, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public IEnumerator DroneWaveLeft()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(droneLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    public IEnumerator DroneWaveRight()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(droneRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    public IEnumerator DroneWaveBoth()
    {
        bool isLeft = true;
        for (int i = 0; i < 6; i++)
        {
            if (isLeft)
            {
                Instantiate(droneLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
                isLeft = false;
            }
            else
            {
                Instantiate(droneRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
                isLeft = true;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    
    public void SingleDroneLeft()
    {
        Instantiate(droneLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void SingleDroneRight()
    {
        Instantiate(droneRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void SpawnSpaceStation()
    {
        float spawnPoint = Random.Range(-5, 6);
        Instantiate(spaceStation, new Vector3(spawnPoint, 8, 0), Quaternion.Euler(0, 0, 0));
    }

    public void SpawnSniperLeft()
    {
        Instantiate(sniperLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void SpawnSniperRight()
    {
        Instantiate(sniperRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void SpawnSniperBoth()
    {
        Instantiate(sniperLeft, new Vector3(-10, 0, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(sniperRight, new Vector3(10, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    public void WaspWave()
    {
        float spawnPoint1 = Random.Range(-8, -3);
        float spawnPoint2 = Random.Range(-2, 3);
        float spawnPoint3 = Random.Range(4, 9);
        Instantiate(wasp, new Vector3(spawnPoint1, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(wasp, new Vector3(spawnPoint2, 6, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(wasp, new Vector3(spawnPoint3, 6, 0), Quaternion.Euler(0, 0, 180));
    }

    public void ClearAllEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }
}
