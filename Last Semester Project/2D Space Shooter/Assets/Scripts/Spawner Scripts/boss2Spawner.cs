using UnityEngine;
using System.Collections;

public class boss2Spawner : MonoBehaviour
{
    public GameObject bossHead;
    public GameObject bossBody;
    public GameObject bossTail;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnBoss()
    {
        int spawnCount = 0;
        while (spawnCount < 10)
        {
            if (spawnCount == 0)
            {
                Instantiate(bossHead, new Vector3(0, 10, 0), Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
            else if (spawnCount == 8)
            {
                Instantiate(bossBody, new Vector3(0, 10, 0), Quaternion.identity);
                yield return new WaitForSeconds(0.4f);
            }
            else if (spawnCount == 9)
            {
                Instantiate(bossTail, new Vector3(0, 10, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(bossBody, new Vector3(0, 10, 0), Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
            spawnCount++;
        }
    }
}
