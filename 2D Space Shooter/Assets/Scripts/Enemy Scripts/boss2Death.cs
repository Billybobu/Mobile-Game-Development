using UnityEngine;

public class boss2Death : MonoBehaviour
{
    // Death explosion effect and audio
    public GameObject deathExplosion;
    public AudioSource audioSource;
    public AudioClip explosionSound;
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

    public void Die()
    {
        enemyScoreAllocator.AllocateScore();
        AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        Instantiate(deathExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
