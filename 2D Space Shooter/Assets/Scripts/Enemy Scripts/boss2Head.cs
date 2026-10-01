using UnityEngine;

public class boss2Head : MonoBehaviour
{
    public int health;
    public bool phaseTwoStarted = false;
    public GameObject launcher1;
    public GameObject launcher2;
    float missileTimer;
    public level2Spawner level2Spawner;
    public boss2Death boss2Death;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Start phase two and fire missiles at intervals
        if (health <= 50 && phaseTwoStarted == false)
        {
            phaseTwoStarted = true;
        }
        if (phaseTwoStarted)
        {
            missileTimer -= Time.deltaTime;
            if (missileTimer <= 0f)
            {
                Vector2 position = transform.position;
                // Check if head is on screen
                if (position.x > -9 && position.x < 9 && position.y > -5 && position.y < 5)
                {
                    launcher1.GetComponent<missileLauncher>().Fire();
                    launcher2.GetComponent<missileLauncher>().Fire();
                    missileTimer = 5f;
                }
            }
        }
        if (health <= 0)
        {
            level2Spawner.bossDefeated = true;
            boss2Death.Die();
        }
    }

    void Awake()
    {
        level2Spawner = FindFirstObjectByType<level2Spawner>();
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            TakeDamage(2);
            Destroy(other.gameObject);
        }
    }

    // Method to handle taking damage
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Boss Destroyed");
        }
    }
}
