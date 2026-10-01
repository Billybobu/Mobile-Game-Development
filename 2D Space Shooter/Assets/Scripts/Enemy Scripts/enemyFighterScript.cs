using UnityEngine;

public class enemyFighterScript : MonoBehaviour
{
    // Health
    public int health;
    public enemyDeathScript enemyDeathScript;
    // Firing
    public float fireDelay;
    float fireTimer;
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Gun3;
    public GameObject Gun4;
    // Audio
    public AudioSource audioSource;
    public AudioClip shootSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire bullets at intervals
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            Fire();
            fireTimer = fireDelay;
        }
    }

    // Fires bullets from all four guns by calling their scripts
    void Fire() 
    {
        audioSource.PlayOneShot(shootSound);
        Gun1.GetComponent<droneGun>().Shoot();
        Gun2.GetComponent<droneGun>().Shoot();
        Gun3.GetComponent<droneGun>().Shoot();
        Gun4.GetComponent<droneGun>().Shoot();
    }

    void Awake()
    {
        fireTimer = fireDelay;
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
}
