using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Health variables
    public int maxHealth = 10;
    public int currentHealth;
    // Death explosion effect
    public GameObject deathExplosion;
    public AudioClip explosionSound;
    // Immunity variables
    bool isImmune = false;
    private SpriteRenderer spriteRenderer;
    private Material defaultMaterial;
    public Material immuneMaterial;
    public float immuneDuration = 1f;
    float immuneTimer = 0f;
    // Reference to game over script
    public gameOver gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultMaterial = spriteRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        // Handles player immunity
        immuneTimer -= Time.deltaTime;
        if (immuneTimer <= 0f && isImmune == true)
        {
            isImmune = false;
            spriteRenderer.material = defaultMaterial;
        }
    }

    // Handles collisions with enemy bullets and enemies
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyBullet") && isImmune == false)
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemy") && isImmune == false)
        {
            TakeDamage(2);
            other.GetComponent<enemyDeathScript>().Die();
        }
        if (other.CompareTag("EnemyMissile") && isImmune == false)
        {
            TakeDamage(2);
            other.GetComponent<missileHealth>().Explode();
        }
        // Handles health power-up collection
        if (other.CompareTag("HealthUpPU")) 
        {
            Destroy(other.gameObject);
            currentHealth += 2;
            if (currentHealth > maxHealth) 
            {
                currentHealth = maxHealth;
            }
        }
    }

    // Handles collisions with bosses
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss") && isImmune == false)
        {
            TakeDamage(2);
        }
    }

    // Handles taking damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // Make player immune for a short duration after taking damage
        isImmune = true;
        immuneTimer = immuneDuration;
        spriteRenderer.material = immuneMaterial; // Change material to indicate immunity
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Handle player death (e.g., reload scene, show game over screen)
        gameOver.playerDead();
        Instantiate(deathExplosion, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        Destroy(gameObject);
    }
}
