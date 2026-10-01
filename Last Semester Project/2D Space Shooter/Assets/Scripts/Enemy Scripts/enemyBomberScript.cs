using UnityEngine;

public class enemyBomberScript : MonoBehaviour
{
    // Health
    public int health;
    public enemyDeathScript enemyDeathScript;
    // Audio
    public AudioSource audioSource;
    public AudioClip shootSound;
    // Firing
    public float fireDelay;
    float fireTimer;
    public GameObject launcher1;
    public GameObject launcher2;
    // Lifetime
    public float lifeTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Fire missiles at intervals when on-screen
        fireTimer -= Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            Vector2 position = transform.position;
            // Check if enemy is on screen
            if (position.x > -9 && position.x < 9 && position.y > -5 && position.y < 5)
            {
                Launch();
                fireTimer = fireDelay;
            }
        }
    }

    // Launches missiles from both launchers by calling their scripts
    void Launch()
    {
        audioSource.PlayOneShot(shootSound);
        launcher1.GetComponent<missileLauncher>().Fire();
        launcher2.GetComponent<missileLauncher>().Fire();
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
