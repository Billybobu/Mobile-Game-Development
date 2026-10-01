using UnityEngine;

public class missileHealth : MonoBehaviour
{
    public float missileTime;
    float timer;
    public GameObject explosionEffect;
    public AudioClip explosionSound;
    public enemyDeathScript enemyDeathScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // Decrease the timer by the time elapsed since the last frame
        if (timer <= 0f)
        {
            Explode(); // Call the Explode method when the timer reaches zero
        }
    }

    void Awake()
    {
        timer = missileTime; // Initialize the timer with the missile's lifetime
    }

    public void Explode()
    {
        // Instantiate explosion effect at the missile's position and rotation
        Instantiate(explosionEffect, transform.position, transform.rotation);
        // Play explosion sound at the missile's position
        AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        Destroy(gameObject); // Destroy the missile object
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet") || other.CompareTag("DoubleDamageBullet"))
        {
            enemyDeathScript.Die();
        }
    }
}
