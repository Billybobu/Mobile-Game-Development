using UnityEngine;

public class enemyDeathScript : MonoBehaviour
{
    // Death explosion effect and audio
    public GameObject deathExplosion;
    public AudioSource audioSource;
    public AudioClip explosionSound;
    // Power-up prefabs
    public GameObject powerUpHealth;
    public GameObject powerUpFireRate;
    public GameObject powerUpDamage;
    public GameObject powerUpTripleShot;
    // Reference to enemyScoreAllocator
    public enemyScoreAllocator enemyScoreAllocator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Handles enemy death
    public void Die()
    {
        int dropChance = Random.Range(0, 8);
        if (dropChance == 1)
        {
            int powerUpType = Random.Range(0, 4);
            if (powerUpType == 0)
            {
                Instantiate(powerUpHealth, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (powerUpType == 1)
            {
                Instantiate(powerUpFireRate, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (powerUpType == 2)
            {
                Instantiate(powerUpDamage, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (powerUpType == 3)
            {
                Instantiate(powerUpTripleShot, transform.position, Quaternion.Euler(0, 0, 0));
            }
        }
        enemyScoreAllocator.AllocateScore();
        AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        Instantiate (deathExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
