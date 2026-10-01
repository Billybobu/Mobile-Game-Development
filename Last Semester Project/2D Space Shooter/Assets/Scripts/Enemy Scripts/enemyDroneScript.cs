using UnityEngine;

public class enemyDroneScript : MonoBehaviour
{
    // Health
    public int health;
    // Firing
    public float fireDelay;
    float fireTimer;
    public GameObject Gun1;
    public GameObject Gun2;
    // Lifetime
    public float lifeTime;
    // Death
    public enemyDeathScript enemyDeathScript;
    // Audio
    public AudioSource audioSource;
    public AudioClip shootSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireTimer = fireDelay;
    }

    // Update is called once per frame
    void Update()
    {
        // Fire bullets at intervals when on-screen
        fireTimer -= Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            Vector2 position = transform.position;
            // Check if the drone is on screen
            if (position.x > -9 && position.x < 9 && position.y > -5 && position.y < 5)
            {
                Fire();
                fireTimer = fireDelay;
            }
        }
    }

    // Fires bullets from both guns by calling their scripts
    void Fire()
    {
        audioSource.PlayOneShot(shootSound);
        Gun1.GetComponent<droneGun>().Shoot();
        Gun2.GetComponent<droneGun>().Shoot();
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            health -= 1;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            health -= 2;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
    }

    // Destroys the drone when it goes off-screen after its lifetime expires
    private void OnBecameInvisible()
    {
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
