using UnityEngine;

public class meteorSpawner : MonoBehaviour
{
    public GameObject meteorSmall;
    public GameObject meteorMedium;
    public GameObject meteorLarge;
    float spawnDelay;
    float spawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnDelay = Random.Range(2f, 5f);
        spawnTimer = spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            SpawnMeteor();
            spawnDelay = Random.Range(3f, 6f);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnMeteor() 
    {
        int meteorSize = Random.Range(1, 4);
        float spawnX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(spawnX, 6f, 0f);
        if (meteorSize == 1) 
        {
            Instantiate(meteorSmall, spawnPosition, transform.rotation);
        }
        else if (meteorSize == 2) 
        {
            Instantiate(meteorMedium, spawnPosition, transform.rotation);
        }
        else if (meteorSize == 3) 
        {
            Instantiate(meteorLarge, spawnPosition, transform.rotation);
        }
    }
}
