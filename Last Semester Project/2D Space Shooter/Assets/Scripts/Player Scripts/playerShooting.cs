using UnityEngine;
using UnityEngine.InputSystem;

public class playerShooting : MonoBehaviour
{
    // Firing
    public GameObject playerProjectile;
    public float fireDelay; // Shots per second calculated as 1 / fireDelay
    float fireCooldown = 0f;
    public float yOffset; // Vertical offset for projectile spawn position so it appears to come from the front of the player
    // Audio
    public AudioSource audioSource;
    public AudioClip shootSound;
    // Power-up variables
    bool doubleFireActive = false;
    float doubleFireTimer = 0f;
    bool tripleShotActive = false;
    float tripleShotTimer = 0f;
    bool doubleDamageActive = false;
    float doubleDamageTimer = 0f;
    public GameObject doubleDamageProjectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Shoot() 
    {
        if (fireCooldown <= 0f)
        {
            Vector2 playerPosition = GetComponent<Rigidbody2D>().position;
            Vector2 projectileOffset = playerPosition + new Vector2(0, yOffset);
            audioSource.PlayOneShot(shootSound);
            if (doubleDamageActive && tripleShotActive)
            {
                Instantiate(doubleDamageProjectile, projectileOffset + new Vector2(-0.2f, 0), Quaternion.Euler(0, 0, 10));
                Instantiate(doubleDamageProjectile, projectileOffset, Quaternion.Euler(0, 0, 0));
                Instantiate(doubleDamageProjectile, projectileOffset + new Vector2(0.2f, 0), Quaternion.Euler(0, 0, -10));
            }
            else if (tripleShotActive)
            {
                Instantiate(playerProjectile, projectileOffset + new Vector2(-0.2f, 0), Quaternion.Euler(0, 0, 10));
                Instantiate(playerProjectile, projectileOffset, Quaternion.Euler(0, 0, 0));
                Instantiate(playerProjectile, projectileOffset + new Vector2(0.2f, 0), Quaternion.Euler(0, 0, -10));
            }
            else if (doubleDamageActive)
            {
                Instantiate(doubleDamageProjectile, projectileOffset, Quaternion.Euler(0, 0, 0));
            }
            else
            {
                Instantiate(playerProjectile, projectileOffset, Quaternion.Euler(0, 0, 0));
            }
            fireCooldown = 1 / fireDelay;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Handles shooting input and cooldown
        fireCooldown -= Time.deltaTime;
        
        // Handles double fire power-up duration
        if (doubleFireActive)
        {
            doubleFireTimer -= Time.deltaTime;
            if (doubleFireTimer <= 0f)
            {
                doubleFireActive = false;
                fireDelay /= 2;
            }
        }
        // Handles triple shot power-up duration
        if (tripleShotActive)
        {
            tripleShotTimer -= Time.deltaTime;
            if (tripleShotTimer <= 0f)
            {
                tripleShotActive = false;
            }
        }
        // Handles double damage power-up duration
        if (doubleDamageActive)
        {
            doubleDamageTimer -= Time.deltaTime;
            if (doubleDamageTimer <= 0f)
            {
                doubleDamageActive = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DoubleFirePU") && doubleFireActive == false)
        {
            Destroy(other.gameObject);
            doubleFireActive = true;
            fireDelay *= 2;
            doubleFireTimer = 15f; // Power-up lasts for 15 seconds
        }
        else if (other.CompareTag("DoubleFirePU") && doubleFireActive == true)
        {
            Destroy(other.gameObject);
            doubleFireTimer = 15f; // Reset timer
        }
        else if (other.CompareTag("TripleShotPU") && tripleShotActive == false)
        {
            Destroy(other.gameObject);
            tripleShotActive = true;
            tripleShotTimer = 15f; // Power-up lasts for 15 seconds
        }
        else if (other.CompareTag("TripleShotPU") && tripleShotActive == true)
        {
            Destroy(other.gameObject);
            tripleShotTimer = 15f; // Reset timer
        }
        else if (other.CompareTag("DoubleDamagePU") && doubleDamageActive == false)
        {
            Destroy(other.gameObject);
            doubleDamageActive = true;
            doubleDamageTimer = 15f; // Power-up lasts for 15 seconds
        }
        else if (other.CompareTag("DoubleDamagePU") && doubleDamageActive == true)
        {
            Destroy(other.gameObject);
            doubleDamageTimer = 15f; // Reset timer
        }
    }
}
