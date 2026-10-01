using UnityEngine;

public class boss2Tail : MonoBehaviour
{
    private boss2Head boss2Head;
    public GameObject launcher1;
    public GameObject launcher2;
    float missileTimer;
    public boss2Death boss2Death;
    public level2Spawner level2Spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire missiles at intervals in phase two
        if (boss2Head.phaseTwoStarted)
        {
            missileTimer -= Time.deltaTime;
            if (missileTimer <= 0f)
            {
                Vector2 position = transform.position;
                // Check if tail is on screen
                if (position.x > -7 && position.x < 7 && position.y > -3 && position.y < 3)
                {
                    launcher1.GetComponent<missileLauncher>().Fire();
                    launcher2.GetComponent<missileLauncher>().Fire();
                    missileTimer = 5f;
                }
            }
        }
        if (level2Spawner.bossDefeated == true)
        {
            boss2Death.Die();
        }
    }

    void Awake()
    {
        boss2Head = FindFirstObjectByType<boss2Head>();
        level2Spawner = FindFirstObjectByType<level2Spawner>();
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            boss2Head.TakeDamage(1);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            boss2Head.TakeDamage(2);
            Destroy(other.gameObject);
        }
    }
}
